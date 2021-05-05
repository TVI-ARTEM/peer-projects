using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Exceptions;

namespace WareHouse.Managers
{
    /// <summary>
    /// Class allow to manage companies.
    /// </summary>
    public static class CompanyManager
    {
        /// <summary>
        /// File name which contains all info about companies.
        /// </summary>
        public const string CompanyPath = "Company.json";

        /// <summary>
        /// List of companies.
        /// </summary>
        private static List<Company> Companies { get; set; }

        static CompanyManager()
        {
            Companies = new List<Company>();
        }

        /// <summary>
        /// Add new company.
        /// </summary>
        /// <param name="company">New company.</param>
        public static void Add(Company company)
        {
            if (NameContains(company.Name))
            {
                throw new CustomDataException(ApplicationStrings.CompanyExistException, 400);
            }

            Companies.Add(company);
        }

        /// <summary>
        /// Get company by name.
        /// </summary>
        /// <param name="companyName">Company name.</param>
        /// <returns>Company.</returns>
        public static Company Get(string companyName)
        {
            if (!NameContains(companyName))
            {
                throw new KeyNotFoundException(ApplicationStrings.CompanyNotFoundException);
            }

            return Companies.First(comp => comp.Name.Equals(companyName, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Check if company with this name exists.
        /// </summary>
        /// <param name="companyName">Company name.</param>
        /// <returns>Result of checking.</returns>
        public static bool NameContains(string companyName)
        {
            return Companies.Any(comp =>
                comp.Name.Equals(companyName, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Check if company with this name and does not equal to other company exists.
        /// </summary>
        /// <param name="company">Other company.</param>
        /// <param name="newName">New company name.</param>
        /// <returns>Result of checking.</returns>
        public static bool CompanyExists(Company company, string newName)
        {
            return Companies.Any(other =>
                !other.Name.Equals(company.Name, StringComparison.InvariantCultureIgnoreCase) &&
                other.Name.Equals(newName, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Get all names of companies.
        /// </summary>
        /// <returns>All names.</returns>
        public static List<string> GetNames()
        {
            return Companies.Select(company => company.Name).ToList();
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
                    Path.Combine(Manager.AppPath, folderName, Manager.DataPath, CompanyPath),
                    FileMode.Create, FileAccess.Write))
                {
                    using (var stream = new StreamWriter(fileStream))
                    {
                        using (JsonWriter writer = new JsonTextWriter(stream))
                        {
                            serializer.Serialize(writer, Companies);
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
                using (var fileStream = new FileStream(Path.Combine(Manager.AppPath, folderName, Manager.DataPath, CompanyPath),
                    FileMode.OpenOrCreate, FileAccess.Read))
                {
                    using (var stream = new StreamReader(fileStream))
                    {
                        using (var reader = new JsonTextReader(stream))
                        {
                            var tempCompanies = deserializer.Deserialize<List<Company>>(reader);

                            if (tempCompanies == null) return;
                            // Add to list.
                            foreach (var company in tempCompanies)
                            {
                                try
                                {
                                    Add(company);
                                }
                                catch
                                {
                                    // ignored
                                }
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

        /// <summary>
        /// Remove all data.
        /// </summary>
        public static void Clear() => Companies.Clear();
    }
}