using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using WareHouse.AppResources;
using WareHouse.Enums;
using WareHouse.Exceptions;
using WareHouse.Helpers;

namespace WareHouse.Entities
{
    public class Order
    {
        #region Fields

        /// <summary>
        /// Order quantity.
        /// </summary>
        private int _quantity;

        #endregion

        #region Properties

        /// <summary>
        /// Order id.
        /// </summary>
        public uint ID { get; set; }
        
        /// <summary>
        /// Order products.
        /// </summary>
        [JsonConverter(typeof(CustomDictionaryConverter<Product, (double, int)>))]
        public Dictionary<Product, (double, int)> OrderProducts { get; set; }

        /// <summary>
        /// Order client.
        /// </summary>
        public Client OrderClient { get; set; }
        /// <summary>
        /// Order status.
        /// </summary>
        public OrderStatus Status { get; set; }
        /// <summary>
        /// Order time creation.
        /// </summary>
        public DateTime TimeFormed { get; set; }
        /// <summary>
        /// Order quantity.
        /// </summary>
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                {
                    throw new CustomDataException(ApplicationStrings.OrderQuantityException);
                }

                _quantity = value;
            }
        }

        #endregion

        #region Constructors

        public Order()
        {
            var md5 = MD5.Create();
            var obj = Guid.NewGuid();
            var str = obj.ToString();
            Quantity = 0;
            ID = BitConverter.ToUInt32(md5.ComputeHash(Encoding.Default.GetBytes(str)), 0);
            OrderProducts = new Dictionary<Product, (double, int)>();
            TimeFormed = DateTime.Now;
            Status = OrderStatus.NotFormed;
        }

        public Order(Product productOrder, double totalPrice, int quantity, Client client) : this()
        {
            Quantity += quantity;
            OrderProducts.Add(productOrder, (totalPrice, quantity));
            OrderClient = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add product to collection.
        /// </summary>
        /// <param name="product">New product.</param>
        /// <param name="totalPrice">Product price.</param>
        /// <param name="quantity">Product quantity.</param>
        public void AddProduct(Product product, double totalPrice, int quantity)
        {
            Quantity += quantity;

            if (OrderProducts.ContainsKey(product))
            {
                OrderProducts[product] = (totalPrice + OrderProducts[product].Item1,
                    quantity + OrderProducts[product].Item2);
                return;
            }

            OrderProducts.Add(product, (totalPrice, quantity));
        }

        /// <summary>
        /// Change order status.
        /// </summary>
        /// <param name="status">New order status.</param>
        public void ChangeStatus(OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.NotFormed:
                    Status = status;
                    break;
                case OrderStatus.Formed:
                    Status = status;
                    break;
                case OrderStatus.Processed:
                    if (!Status.HasFlag(OrderStatus.Formed))
                        throw new CustomDataException(ApplicationStrings.OrderFormedException);

                    Status |= status;
                    break;
                case OrderStatus.PaidUp:
                    if (!Status.HasFlag(OrderStatus.Processed))
                        throw new CustomDataException(ApplicationStrings.OrderProcessedException);

                    Status |= status;
                    break;
                case OrderStatus.Shipped:
                    if (!Status.HasFlag(OrderStatus.PaidUp))
                        throw new CustomDataException(ApplicationStrings.OrderPaidUpException);

                    Status |= status;
                    break;
                case OrderStatus.Completed:
                    if (!Status.HasFlag(OrderStatus.Shipped))
                        throw new CustomDataException(ApplicationStrings.OrderShippedException);

                    Status |= status;
                    break;
            }
        }

        #endregion
    }
}