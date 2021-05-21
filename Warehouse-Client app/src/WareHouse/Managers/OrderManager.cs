using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using WareHouse.Entities;
using WareHouse.Enums;

namespace WareHouse.Managers
{
    public class OrderManager
    {
        public const string OrderPath = "Order.json";

        /// <summary>
        /// List of clients.
        /// </summary>
        private static List<Order> Orders { get; }

        static OrderManager()
        {
            Orders = new List<Order>();
        }

        /// <summary>
        /// Add new order to collection.
        /// </summary>
        /// <param name="client">New client.</param>
        /// <param name="product">New product to order.</param>
        /// <param name="price">Product totally price.</param>
        /// <param name="quantity">Product quantity.</param>
        public static void Add(Client client, Product product, double price, int quantity)
        {
            if (Orders.Any(order => order.OrderClient.Equals(client) && !order.Status.HasFlag(OrderStatus.Formed)))
            {
                Orders.First(order => order.OrderClient.Equals(client) && !order.Status.HasFlag(OrderStatus.Formed)).AddProduct(product, price, quantity);
            }
            else
            {
                Orders.Add(new Order(product, price, quantity, client));
            }
        }

        /// <summary>
        /// Get copy of orders collection.
        /// </summary>
        /// <returns>Orders.</returns>
        public static List<Order> GetOrders()
        {
            return Orders.ToList();
        }


        /// <summary>
        /// Get copy of orders collection.
        /// </summary>
        /// <param name="client">Order client.</param>
        /// <returns>Orders.</returns>
        public static List<Order> GetOrders(Client client)
        {
            return Orders.Where(order => order.OrderClient.Equals(client)).ToList();
        }

        /// <summary>
        /// Save data.
        /// </summary>
        public static void Save(string folderName)
        {
            try
            {
                var serializer = new JsonSerializer {Formatting = Formatting.Indented};

                using (var fileStream = new FileStream(
                    Path.Combine(Manager.AppPath, folderName, Manager.DataPath, OrderPath),
                    FileMode.Create))
                {
                    using (var stream = new StreamWriter(fileStream))
                    {
                        using (var writer = new JsonTextWriter(stream))
                        {
                            serializer.Serialize(writer, Orders);
                        }
                    }
                }
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Load data.
        /// </summary>
        public static void Load(string folderName)
        {
            try
            {
                var deserializer = new JsonSerializer {Formatting = Formatting.Indented};
                using (var fileStream = new FileStream(
                    Path.Combine(Manager.AppPath, folderName, Manager.DataPath, OrderPath),
                    FileMode.OpenOrCreate, FileAccess.Read))
                {
                    using (var stream = new StreamReader(fileStream))
                    {
                        using (var reader = new JsonTextReader(stream))
                        {
                            var tempOrders = deserializer.Deserialize<List<Order>>(reader);

                            if (tempOrders == null) return;


                            foreach (var order in tempOrders)
                                try
                                {
                                    ClientManager.GetByName(order.OrderClient.Login);
                                    Orders.Add(order);
                                }
                                catch 
                                {
                                    // ignored
                                }
                        }
                    }
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}