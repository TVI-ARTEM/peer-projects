using System;
using System.Collections.Generic;
using System.Linq;
using WareHouse.AppResources;
using WareHouse.Exceptions;
using WareHouse.Managers;

namespace WareHouse.Entities
{
    /// <summary>
    /// Class description section which contains names of product in current section.
    /// </summary>
    public class Section : ICloneable
    {
        #region Field

        /// <summary>
        /// Section name.
        /// </summary>
        private string _name;

        #endregion

        #region Properties

        /// <summary>
        /// Section path.
        /// </summary>
        public List<string> Path { get; set; }
        /// <summary>
        /// Section products.
        /// </summary>
        public List<string> Products { get; set; }
        /// <summary>
        /// Section child sections.
        /// </summary>
        public List<string> Sections { get; set; }

        /// <summary>
        /// Section name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                value = value.Trim();
                if (!CheckName(value)) throw new CustomDataException(ApplicationStrings.NameSectionException, 101);

                _name = value;
            }
        }

        #endregion

        #region Checking

        /// <summary>
        /// Check section name for valid.
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

        #endregion

        #region Constructors

        private Section()
        {
            Path = new List<string>();
            Products = new List<string>();
            Sections = new List<string>();
        }

        public Section(string name) : this()
        {
            Name = name;
            Path.Add(name);
        }

        public Section(string name, List<string> path) : this(name)
        {
            Path.InsertRange(0, path);
        }

        #endregion


        /// <summary>
        /// Check other section for equal.
        /// </summary>
        /// <param name="other">Other section.</param>
        /// <returns>Result of checking.</returns>
        public bool Equals(Section other)
        {
            return Path.Count == other.Path.Count && !Path.Where((t, i) => t != other.Path[i]).Any() && Name.Equals(
                other.Name,
                StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Check if other section is child section of current.
        /// </summary>
        /// <param name="other">Other section.</param>
        /// <returns>Result of checking.</returns>
        public bool IsSubSection(Section other)
        {
            return Path.Count < other.Path.Count && !Path.Where((t, i) => t != other.Path[i]).Any();
        }

        /// <summary>
        /// Get section products.
        /// </summary>
        /// <returns>Section products.</returns>
        public List<Product> GetProducts()
        {
            return ProductManager.GetProducts().Where(product => product.Path.SequenceEqual(Path)).ToList();
        }

        /// <summary>
        /// Get section child sections.
        /// </summary>
        /// <returns>Child sections.</returns>
        public List<Section> GetSections()
        {
            return SectionManager.GetSections().Where(IsSubSection).ToList();
        }

        /// <summary>
        /// Change name of section.
        /// </summary>
        /// <param name="name">New name.</param>
        public void Rename(string name)
        {
            var tempList = Path.ToList();
            tempList[Path.Count - 1] = name;

            SectionManager.ChangePath(this, tempList);

            Name = name;
            Path[Path.Count - 1] = Name;
        }

        /// <summary>
        /// Clone data to object.
        /// </summary>
        /// <returns>Clone object.</returns>
        public object Clone() => MemberwiseClone();

        /// <summary>
        /// Get total quantity of all products in current section and it's child section.
        /// </summary>
        /// <returns>Total quantity.</returns>
        public int GetTotalQuantity()
        {
            var quantity = GetProducts().Sum(product => product.Quantity) +
                           GetSections().Sum(section => section.GetProducts().Sum(product => product.Quantity));

            return quantity;
        }

        /// <summary>
        /// Get total price of all products in current section and it's child section.
        /// </summary>
        /// <returns>Total price.</returns>
        public double GetTotalPrice()
        {
            var quantity = GetProducts().Sum(product => product.Price) +
                           GetSections().Sum(section => section.GetProducts().Sum(product => product.Price));

            return quantity;
        }
    }
}