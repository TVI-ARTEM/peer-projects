using System;
using System.Linq;
using WareHouse.AppResources;
using WareHouse.Exceptions;
using WareHouse.Managers;

namespace WareHouse.Entities
{
    /// <summary>
    /// The class contains a description of a company that produces certain products.
    /// </summary>
    public class Company
    {
        #region Fields

        /// <summary>
        /// Company name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Company address.
        /// </summary>
        private string _address;

        /// <summary>
        /// Company phone number.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Company chief name.
        /// </summary>
        private string _chief;

        #endregion

        #region Properties

        /// <summary>
        /// Company description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Company photo in format base64.
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                value = value.Trim();
                if (!CheckName(value))
                {
                    throw new CustomDataException(ApplicationStrings.NameCompanyException, 101);
                }

                _name = value;
            }
        }

        /// <summary>
        /// Company address.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                value = value.Trim();
                if (!CheckAddress(value))
                {
                    throw new CustomDataException(ApplicationStrings.AdressCompanyException, 102);
                }

                _address = value;
            }
        }

        /// <summary>
        /// Company phone number.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                value = value.Trim();
                if (!CheckPhoneNumber(value))
                {
                    throw new CustomDataException(ApplicationStrings.PhoneNumberCompanyException, 103);
                }

                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Company chief name.
        /// </summary>
        public string Chief
        {
            get => _chief;
            set
            {
                value = value.Trim();

                if (!CheckName(value))
                {
                    throw new CustomDataException(ApplicationStrings.ChiefCompanyException, 104);
                }

                _chief = value;
            }
        }

        #endregion

        #region Checking

        /// <summary>
        /// Check company name for valid.
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
                       || letter.Equals('-')
                       || char.IsWhiteSpace(letter)
                   );
        }

        /// <summary>
        /// Check company address for valid.
        /// </summary>
        /// <param name="value">Address.</param>
        /// <returns>Result of checking.</returns>
        private static bool CheckAddress(string value)
        {
            return value.Length > 0 &&
                   value.All(letter =>
                       'A' <= letter && letter <= 'Z'
                       || 'a' <= letter && letter <= 'z'
                       || 'А' <= letter && letter <= 'Я'
                       || 'а' <= letter && letter <= 'я'
                       || letter.Equals('-')
                       || char.IsDigit(letter)
                       || char.IsWhiteSpace(letter)
                   );
        }

        /// <summary>
        /// Check company phone number for valid.
        /// </summary>
        /// <param name="value">Phone number.</param>
        /// <returns>Result of checking.</returns>
        private static bool CheckPhoneNumber(string value)
        {
            return value.Length > 0 &&
                   value.All(letter =>
                       letter.Equals('-')
                       || char.IsDigit(letter)
                       || char.IsWhiteSpace(letter)
                   );
        }

        #endregion

        /// <summary>
        /// Rename company name and change it everywhere.
        /// </summary>
        /// <param name="newName">New company name.</param>
        public void Rename(string newName)
        {
            if (CompanyManager.CompanyExists(this, newName))
            {
                throw new CustomDataException(ApplicationStrings.CompanyExistException, 101);
            }

            var products = ProductManager.GetProducts()
                .Where(x => x.Company.Equals(Name, StringComparison.InvariantCultureIgnoreCase));

            foreach (var product in products)
            {
                product.Company = newName;
            }

            Name = newName;
        }

        /// <summary>
        /// Clone data from other company.
        /// </summary>
        /// <param name="other">Other company.</param>
        public void Clone(Company other)
        {
            Rename(other.Name);
            Address = other.Address;
            Chief = other.Chief;
            PhoneNumber = other.PhoneNumber;
            Description = other.Description;
            Photo = other.Photo;
        }
    }
}