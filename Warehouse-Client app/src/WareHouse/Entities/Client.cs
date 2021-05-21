using System;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using WareHouse.AppResources;
using WareHouse.Enums;
using WareHouse.Exceptions;

namespace WareHouse.Entities
{
    public class Client : IEquatable<Client>
    {
        #region Fields

        /// <summary>
        /// Client login.
        /// </summary>
        private string _login;

        /// <summary>
        /// Client email.
        /// </summary>
        private string _email;

        /// <summary>
        /// Client city id.
        /// </summary>
        private int _clientCityId;

        /// <summary>
        /// Client password salt. 
        /// </summary>
        [JsonProperty(PropertyName = "Salt")] private byte[] _salt;

        /// <summary>
        /// Client password.
        /// </summary>
        [JsonProperty(PropertyName = "Pass")] private byte[] _password;

        /// <summary>
        /// Client first name.
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Client patronymic.
        /// </summary>
        private string _patronymic;

        /// <summary>
        /// Client last name.
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Client phone number.
        /// </summary>
        private string _phoneNumber;

        #endregion

        #region Properties

        /// <summary>
        /// Client login type.
        /// </summary>
        public Login LoginType { get; set; }


        /// <summary>
        /// Client login.
        /// </summary>
        public string Login
        {
            get => _login;
            set
            {
                value = value.Trim();
                if (!CheckLoginValid(value)) throw new CustomDataException(ApplicationStrings.ClientLoginNameException);

                _login = value;
            }
        }

        /// <summary>
        /// Client email.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                value = value.Trim();
                if (!CheckEMailValid(value)) throw new CustomDataException(ApplicationStrings.ClientEmailException);

                _email = value;
            }
        }

        /// <summary>
        /// Client city id.
        /// </summary>
        public int ClientCityId
        {
            get => _clientCityId;
            set
            {
                City.GetById(value);
                _clientCityId = value;
            }
        }


        /// <summary>
        /// Set client password.
        /// </summary>
        public string Password
        {
            set
            {
                value = value.Trim();
                if (!CheckPasswordValid(value))
                    throw new CustomDataException(ApplicationStrings.ClientPasswordException);

                using (var deriveBytes = new Rfc2898DeriveBytes(value, 20))
                {
                    _salt = deriveBytes.Salt;
                    _password = deriveBytes.GetBytes(20);
                }
            }
        }


        /// <summary>
        /// Client first name.
        /// </summary>
        public string FirstName
        {
            get => _firstName;
            set
            {
                value = value.Trim();
                if (!CheckNameValid(value)) throw new CustomDataException(ApplicationStrings.ClientFirstNameException);

                _firstName = value;
            }
        }

        /// <summary>
        /// Client patronymic.
        /// </summary>
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                value = value.Trim();
                if (!CheckNameValid(value)) throw new CustomDataException(ApplicationStrings.ClientPatronymicException);

                _patronymic = value;
            }
        }

        /// <summary>
        /// Client last name.
        /// </summary>
        public string LastName
        {
            get => _lastName;
            set
            {
                value = value.Trim();
                if (!CheckNameValid(value)) throw new CustomDataException(ApplicationStrings.ClientLastNameException);

                _lastName = value;
            }
        }


        /// <summary>
        /// Client phone number.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                value = value.Trim().Replace(" ", "");
                if (!CheckPhoneNumberValid(value))
                    throw new CustomDataException(ApplicationStrings.ClienPhoneNumberException);

                _phoneNumber = value;
            }
        }

        #endregion

        #region Check values

        /// <summary>
        /// Check phone number.
        /// </summary>
        /// <param name="value">Phone number.</param>
        /// <returns>Result of validation.</returns>
        private static bool CheckPhoneNumberValid(string value)
        {
            var regex = new Regex(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$", RegexOptions.IgnoreCase);
            return regex.IsMatch(value);
        }

        /// <summary>
        /// Check name.
        /// </summary>
        /// <param name="value">Name.</param>
        /// <returns>Result of validation.</returns>
        private static bool CheckNameValid(string value)
        {
            var regex = new Regex(@"^[A-Z-А-Я-а-яa-z_ ]{2,25}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(value);
        }

        /// <summary>
        /// Check login.
        /// </summary>
        /// <param name="value">Login.</param>
        /// <returns>Result of validation.</returns>
        private static bool CheckLoginValid(string value)
        {
            var regex = new Regex(@"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$", RegexOptions.IgnoreCase);
            return regex.IsMatch(value);
        }

        /// <summary>
        /// Check password.
        /// </summary>
        /// <param name="value">Password.</param>
        /// <returns>Result of validation.</returns>
        private static bool CheckPasswordValid(string value)
        {
            var regex = new Regex(@"^(?=.*[A-Za-z-_])(?=.*\d)[A-Za-z-_\d]{3,15}$",
                RegexOptions.IgnoreCase);

            return regex.IsMatch(value);
        }

        /// <summary>
        /// Check email.
        /// </summary>
        /// <param name="value">Email.</param>
        /// <returns>Result of validation.</returns>
        private static bool CheckEMailValid(string value)
        {
            try
            {
                var mailAddress = new MailAddress(value);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        #endregion

        #region Comparing

        /// <summary>
        /// Compare data with others.
        /// </summary>
        /// <param name="userName">User login or email.</param>
        /// <param name="password">User password.</param>
        /// <param name="loginType">User login type.</param>
        /// <returns>Result of validation.</returns>
        public bool CompareData(string userName, string password, Login loginType)
        {
            byte[] comparePassword;
            using (var deriveBytes = new Rfc2898DeriveBytes(password, _salt))
            {
                comparePassword = deriveBytes.GetBytes(20);
            }

            return (Email.Equals(userName) || Login.Equals(userName)) && comparePassword.SequenceEqual(_password) &&
                   LoginType.Equals(loginType);
        }

        /// <summary>
        /// Compare users.
        /// </summary>
        /// <param name="other">Other user.</param>
        /// <returns>Result of validation.</returns>
        public bool Equals(Client other)
        {
            return other != null && (Email.Equals(other.Email, StringComparison.InvariantCultureIgnoreCase) ||
                                     Login.Equals(other.Login, StringComparison.InvariantCultureIgnoreCase)) &&
                   LoginType.Equals(other.LoginType);
        }

        #endregion
    }
}