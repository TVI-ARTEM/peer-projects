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
    /// Class allow to manage products data.
    /// </summary>
    public class ProductManager
    {
        public const string ProductPath = "Product.json";

        /// <summary>
        /// List of products.
        /// </summary>
        private static List<Product> Products { get; set; }

        static ProductManager()
        {
            Products = new List<Product>();
        }


        /// <summary>
        /// Add new product to collection.
        /// </summary>
        /// <param name="product">New product.</param>
        public static void Add(Product product)
        {
            if (NameContains(product.Name, product.Path))
            {
                throw new CustomDataException(ApplicationStrings.ProductExistException, 400);
            }

            var tempSection = SectionManager.Get(product.Path[product.Path.Count - 1], product.Path);
            tempSection.Products.Add(product.Name);
            Products.Add(product);
        }

        /// <summary>
        /// Remove product from collection.
        /// </summary>
        /// <param name="product">Deleting product.</param>
        public static void Remove(Product product)
        {
            var tempSection = SectionManager.Get(product.Path[product.Path.Count - 1], product.Path);
            tempSection.Products.Remove(product.Name);
            Products.Remove(product);
        }

        /// <summary>
        /// Get product by name and path.
        /// </summary>
        /// <param name="name">Product name.</param>
        /// <param name="path">Product path.</param>
        /// <returns>Certain product.</returns>
        public static Product Get(string name, List<string> path)
        {
            if (!NameContains(name, path))
            {
                throw new KeyNotFoundException(ApplicationStrings.ProductNotFoundException);
            }

            var tempProducts = new Product {Name = name, Path = path};

            return Products.First(product => product.Equals(tempProducts));
        }

        /// <summary>
        /// Check if product with this name and path exist.
        /// </summary>
        /// <param name="name">Product name.</param>
        /// <param name="path">Product path.</param>
        /// <returns>Result of checking.</returns>
        public static bool NameContains(string name, List<string> path)
        {
            var tempProducts = new Product {Name = name, Path = path};
            return Products.Any(sect => sect.Equals(tempProducts));
        }

        /// <summary>
        /// Get copy of products collection.
        /// </summary>
        /// <returns>Products.</returns>
        public static List<Product> GetProducts() => Products.ToList();

        public static bool ProductExists(Product product, string newName)
        {
            return Products.Any(other =>
                product.Path.SequenceEqual(other.Path) && !product.Name.Equals(other.Name) &&
                other.Name.Equals(newName, StringComparison.InvariantCultureIgnoreCase));
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
                    Path.Combine(Manager.AppPath, folderName, Manager.DataPath, ProductPath),
                    FileMode.Create))
                {
                    using (var stream = new StreamWriter(fileStream))
                    {
                        using (JsonWriter writer = new JsonTextWriter(stream))
                        {
                            serializer.Serialize(writer, Products);
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
                    Path.Combine(Manager.AppPath, folderName, Manager.DataPath, ProductPath),
                    FileMode.OpenOrCreate, FileAccess.Read))
                {
                    using (var stream = new StreamReader(fileStream))
                    {
                        using (var reader = new JsonTextReader(stream))
                        {
                            var tempProducts = deserializer.Deserialize<List<Product>>(reader);

                            if (tempProducts == null) return;


                            foreach (var product in tempProducts)
                            {
                                try
                                {
                                    Add(product);
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
        /// Check if any section really contain certain product.
        /// </summary>
        public static void CheckProducts()
        {
            try
            {
                for (var i = 0; i < Products.Count; i++)
                {
                    try
                    {
                        // Remove product if certain section does not exist.
                        if (SectionManager.NameContains(Products[i].Path[Products[i].Path.Count - 1], Products[i].Path))
                        {
                            // Remove product if certain section does not contain certain product.
                            if (!SectionManager.Get(Products[i].Path[Products[i].Path.Count - 1], Products[i].Path)
                                    .Products.Contains(Products[i].Name) ||
                                !CompanyManager.NameContains(Products[i].Company))
                            {
                                Products.RemoveAt(i--);
                            }
                        }
                        else
                        {
                            Products.RemoveAt(i--);
                        }
                    }
                    catch
                    {
                        // ignored
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
        public static void Clear() => Products.Clear();
    }
}