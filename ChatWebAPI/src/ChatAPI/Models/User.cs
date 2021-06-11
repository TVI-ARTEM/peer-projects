using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using ChatAPI.Exceptions;

namespace ChatAPI.Models
{
    public class User : IEquatable<User>
    {
        /// <summary>
        /// User login.
        /// </summary>
        private string _login;
        /// <summary>
        /// User email.
        /// </summary>
        private string _email;
        /// <summary>
        /// User salt.
        /// </summary>
        public byte[] Salt { get; private set; }
        /// <summary>
        /// User pass.
        /// </summary>
        public byte[] Pass { get; private set; }

        /// <summary>
        /// User login.
        /// </summary>
        [Required]
        public string Login
        {
            get => _login;
            set
            {
                value = value.Trim();
                if (!CheckLoginValid(value)) throw new CustomException("Incorrect login.");

                _login = value;
            }
        }

        /// <summary>
        /// User email.
        /// </summary>
        [Key]
        [Required]
        public string Email
        {
            get => _email;
            set
            {
                value = value.Trim();
                if (!CheckEMailValid(value)) throw new CustomException("Incorrect e-mail.");

                _email = value;
            }
        }

        /// <summary>
        /// Set user password.
        /// </summary>
        [Required]
        public string Password
        {
            set
            {
                value = value.Trim();
                if (!CheckPasswordValid(value))
                    throw new CustomException("Incorrect password.");

                using var deriveBytes = new Rfc2898DeriveBytes(value, 20);

                Salt = deriveBytes.Salt;
                Pass = deriveBytes.GetBytes(20);
            }
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
                var _ = new MailAddress(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Check for equals.
        /// </summary>
        /// <param name="other">Other user.</param>
        /// <returns>Result of checking.</returns>
        public bool Equals(User other)
        {
            return other != null && _email == other._email;
        }

        /// <summary>
        /// Check for equals.
        /// </summary>
        /// <param name="obj">Other user.</param>
        /// <returns>Result of checking.</returns>
        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType() == GetType() && Equals((User) obj);
        }

        /// <summary>
        /// User unique hash code.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(_login, _email, Salt, Pass);
        }

        /// <summary>
        /// Generate users.
        /// </summary>
        /// <param name="count">Quantity of users.</param>
        /// <returns>Generated users.</returns>
        public static IEnumerable<User> GenerateUsers(int count)
        {
            var random = new Random();

            for (var i = 0; i < count; i++)
            {
                var email = $"address{i + 1}@mail.ru";
                var login = $"login{i + 1}";
                var password = $"pass{i + 1}";

                yield return new User {Email = email, Login = login, Password = password};
            }
        }
    }
}