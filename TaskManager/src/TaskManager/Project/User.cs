using System;
using System.Linq;

namespace ProjectLibrary
{
    [Serializable]
    public class User
    {
        /// <summary>
        /// Field user name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Property user name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                value = value.Trim();

                if (!NameValidator(value))
                {
                    throw new ArgumentException("The name must contain only Latin letters and spaces.");
                }

                _name = value;
            }
        }

        /// <summary>
        /// Check user name for valid.
        /// </summary>
        /// <param name="name">Checking name.</param>
        /// <returns>Result of checking.</returns>
        private static bool NameValidator(string name)
        {
            return !string.IsNullOrEmpty(name) && name.All(letter =>
                (letter > 'A' - 1 && letter < 'Z' + 1)
                || (letter > 'a' - 1 && letter < 'z' + 1)
                || char.IsWhiteSpace(letter)
            );
        }

        /// <summary>
        /// Property user hire date time.
        /// </summary>
        public DateTime HireDateTime { get; set; }

        /// <summary>
        /// Constructor only for json.
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// User constructor.
        /// </summary>
        /// <param name="name">User name.</param>
        public User(string name)
        {
            Name = name;
            HireDateTime = DateTime.Now;
        }

        /// <summary>
        /// Get user info.
        /// </summary>
        /// <returns>User info.</returns>
        public override string ToString() => $"Name: {Name}; Hire date time: {HireDateTime}";
    }
}