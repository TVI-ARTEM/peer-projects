using System;
using System.Collections.Generic;
using System.Linq;
using WareHouse.AppResources;
using WareHouse.Enums;
using WareHouse.Exceptions;
using WareHouse.Managers;

namespace WareHouse.Entities
{
    /// <summary>
    /// The class contains the description of the product.
    /// </summary>
    public class Product : ICloneable
    {
        #region Fields

        /// <summary>
        /// Product name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Product UCN.
        /// </summary>
        private string _ucn;

        /// <summary>
        /// Product price.
        /// </summary>
        private double _price;

        /// <summary>
        /// Product quantity.
        /// </summary>
        private int _quantity;

        /// <summary>
        /// Product code.
        /// </summary>
        private string _code;

        /// <summary>
        /// Product discount.
        /// </summary>
        private double _discount;

        #endregion

        #region Properties

        /// <summary>
        /// Product country id.
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Product status.
        /// </summary>
        public Status Status => CheckAvailable();

        /// <summary>
        /// Product guarantee.
        /// </summary>
        public Guarantee Guarantee { get; set; }

        /// <summary>
        /// Product currency.
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Product description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Product photo in format base64.
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// Product company name.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Product path.
        /// </summary>
        public List<string> Path { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                value = value.Trim();
                if (!CheckName(value))
                {
                    throw new CustomDataException(ApplicationStrings.NameProductException, 101);
                }

                _name = value;
            }
        }

        /// <summary>
        /// Product UCN.
        /// </summary>
        public string UCN
        {
            get => _ucn;
            set
            {
                value = value.Trim();
                if (!CheckUcn(value))
                {
                    throw new CustomDataException(ApplicationStrings.UcnProductException, 102);
                }

                _ucn = value;
            }
        }

        /// <summary>
        /// Product price.
        /// </summary>
        public double Price
        {
            get => _price;
            set
            {
                if (value < 0)
                {
                    throw new CustomDataException(ApplicationStrings.PriceProductException, 201);
                }

                _price = value;
            }
        }

        /// <summary>
        /// Product quantity.
        /// </summary>
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity < 0)
                {
                    throw new CustomDataException(ApplicationStrings.QuantityProductException, 202);
                }

                _quantity = value;
            }
        }

        /// <summary>
        /// Product code.
        /// </summary>
        public string Code
        {
            get => _code;
            set
            {
                value = value.Trim();
                if (!CheckCode(value))
                {
                    throw new CustomDataException(ApplicationStrings.CodeProductException, 103);
                }

                _code = value;
            }
        }

        /// <summary>
        /// Product discount.
        /// </summary>
        public double Discount
        {
            get => _discount;
            set
            {
                if (value < 0 || value >= 100)
                {
                    throw new CustomDataException(ApplicationStrings.DiscountProductException, 203);
                }

                _discount = value;
            }
        }

        #endregion

        #region Checking

        /// <summary>
        /// Check product name for valid.
        /// </summary>
        /// <param name="value">Name.</param>
        /// <returns>Result of checking.</returns>
        private static bool CheckName(string value)
        {
            return value.Length > 0 &&
                   value.All(letter =>
                       'A' <= letter && letter <= 'Z'
                       || 'a' <= letter && letter <= 'z'
                       || 'А' <= letter && letter <= 'Я'
                       || 'а' <= letter && letter <= 'я'
                       || char.IsDigit(letter)
                       || char.IsWhiteSpace(letter)
                   );
        }

        /// <summary>
        /// Check product UCN for valid.
        /// </summary>
        /// <param name="value">UCN.</param>
        /// <returns>Result of checking.</returns>
        private static bool CheckUcn(string value)
        {
            return value.Length > 0 &&
                   value.All(letter =>
                       'A' <= letter && letter <= 'Z'
                       || 'a' <= letter && letter <= 'z'
                       || char.IsDigit(letter)
                       || letter.Equals('-')
                   );
        }

        /// <summary>
        /// Check product code. for valid.
        /// </summary>
        /// <param name="value">Code.</param>
        /// <returns>Result of checking.</returns>
        private static bool CheckCode(string value)
        {
            return value.Length > 0 &&
                   value.All(letter =>
                       'A' <= letter && letter <= 'Z'
                       || 'a' <= letter && letter <= 'z'
                       || char.IsDigit(letter)
                       || letter.Equals('-')
                   );
        }

        /// <summary>
        /// Set product status by data about product quantity.
        /// </summary>
        /// <returns></returns>
        private Status CheckAvailable()
        {
            return Quantity > 0 ? Status.InStock : Status.Unavailable;
        }

        #endregion

        /// <summary>
        /// Check two products for equal.
        /// </summary>
        /// <param name="other">Other product.</param>
        /// <returns>Result of checking.</returns>
        public bool Equals(Product other)
        {
            return Path.SequenceEqual(other.Path) && Name.Equals(other.Name,
                StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Clone object data.
        /// </summary>
        /// <returns>Clone object.</returns>
        public object Clone() => MemberwiseClone();

        /// <summary>
        /// Clone data from other product.
        /// </summary>
        /// <param name="other">Other product.</param>
        public void Clone(Product other)
        {
            Rename(other.Name);
            Code = other.Code;
            UCN = other.UCN;
            Price = other.Price;
            Quantity = other.Quantity;
            Discount = other.Discount;
            Country = other.Country;
            Guarantee = other.Guarantee;
            Currency = other.Currency;
            Description = other.Description;
            Photo = other.Photo;
            Company = other.Company;
            Path = other.Path;
        }

        /// <summary>
        /// Rename product name and change it everywhere.
        /// </summary>
        /// <param name="newName">New product name.</param>
        public void Rename(string newName)
        {
            if (ProductManager.ProductExists(this, newName))
            {
                throw new CustomDataException(ApplicationStrings.ProductExistException, 101);
            }

            var tempSection = SectionManager.Get(Path[Path.Count - 1], Path);
            for (var i = 0; i < tempSection.Products.Count; i++)
            {
                if (tempSection.Products[i] != Name) continue;

                tempSection.Products[i] = newName;
                break;
            }

            Name = newName;
        }
    }
}