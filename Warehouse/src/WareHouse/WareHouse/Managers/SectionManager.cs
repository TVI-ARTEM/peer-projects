using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Exceptions;
using WareHouse.Helpers;

namespace WareHouse.Managers
{
    /// <summary>
    /// Class allow to manage section data.
    /// </summary>
    public static class SectionManager
    {
        public const string SectionPath = "Section.json";

        /// <summary>
        /// Section collection.
        /// </summary>
        private static List<Section> Sections { get; set; }

        static SectionManager()
        {
            Sections = new List<Section>();
        }

        /// <summary>
        /// Add new section.
        /// </summary>
        /// <param name="section">New section.</param>
        public static void Add(Section section)
        {
            if (NameContains(section.Name, section.Path))
            {
                throw new CustomDataException(ApplicationStrings.SectionExistException, 400);
            }

            Sections.Add(section);
        }

        /// <summary>
        /// Remove certain section and all of it's products and subsection..
        /// </summary>
        /// <param name="section">Deleting section.</param>
        public static void Remove(Section section)
        {
            var products = ProductManager.GetProducts().Where(x => x.Path.SequenceEqual(section.Path)).ToList();
            foreach (var product in products)
            {
                ProductManager.Remove(product);
            }

            var sections = Sections.Where(section.IsSubSection).ToList().Clone();
            foreach (var sect in sections)
            {
                Remove(sect);
            }

            Sections.Remove(section);
        }

        /// <summary>
        /// Get section by name and path.
        /// </summary>
        /// <param name="name">Section name.</param>
        /// <param name="path">Section path.</param>
        /// <returns>Certain section.</returns>
        public static Section Get(string name, List<string> path)
        {
            if (!NameContains(name, path))
            {
                throw new KeyNotFoundException(ApplicationStrings.SectionNotFoundException);
            }

            var tempSection = new Section(name) {Path = path};
            return Sections.First(section => section.Equals(tempSection));
        }

        /// <summary>
        /// Check if section with this name and path already exists.
        /// </summary>
        /// <param name="name">Section name.</param>
        /// <param name="path">Section path.</param>
        /// <returns>Result of checking.</returns>
        public static bool NameContains(string name, List<string> path)
        {
            var tempSection = new Section(name) {Path = path};
            return Sections.Any(sect => sect.Equals(tempSection));
        }

        /// <summary>
        /// Check if section with this name and does not equal to other already exists.
        /// </summary>
        /// <param name="section">Section for checking.</param>
        /// <param name="newName">Section new name.</param>
        /// <returns>Result of checking.</returns>
        public static bool SectionExists(Section section, string newName)
        {
            return Sections.Any(sect =>
                !sect.Equals(section) && sect.Name.Equals(newName, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Change section path.
        /// </summary>
        /// <param name="section">Section</param>
        /// <param name="changedList">New section path.</param>
        public static void ChangePath(Section section, List<string> changedList)
        {
            foreach (var sect in Sections.Where(section.IsSubSection).ToList())
            {
                for (var i = 0; i < changedList.Count; i++)
                {
                    sect.Path[i] = changedList[i];
                }
            }
        }

        /// <summary>
        /// Get clone of section collection.
        /// </summary>
        /// <returns>Section collection.</returns>
        public static List<Section> GetSections() => Sections.ToList();

        /// <summary>
        /// Save data.
        /// </summary>
        public static void Save(string folderName)
        {
            try
            {
                var serializer = new JsonSerializer { Formatting = Formatting.Indented };

                using (var fileStream = new FileStream(Path.Combine(Manager.AppPath, folderName, Manager.DataPath, SectionPath), FileMode.Create))
                {
                    using (var stream = new StreamWriter(fileStream))
                    {
                        using (JsonWriter writer = new JsonTextWriter(stream))
                        {
                            serializer.Serialize(writer, Sections);
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
                var deserializer = new JsonSerializer { Formatting = Formatting.Indented };
                using (var fileStream = new FileStream(Path.Combine(Manager.AppPath, folderName, Manager.DataPath, SectionPath),
                    FileMode.OpenOrCreate, FileAccess.Read))
                {
                    using (var stream = new StreamReader(fileStream))
                    {
                        using (var reader = new JsonTextReader(stream))
                        {
                            var tempSections = deserializer.Deserialize<List<Section>>(reader);


                            if (tempSections == null) return;
                            tempSections.Sort((a, b) => a.Path.Count.CompareTo(b.Path.Count));

                            for (var i = 0; i < tempSections.Count; i++)
                            {
                                try
                                {
                                    // Check if section does not have parent section.
                                    if (tempSections[i].Path.Count > 1 && !tempSections.Any(x=>  x.IsSubSection(tempSections[i]) && x.Path.Count + 1 == tempSections[i].Path.Count))
                                    {
                                        tempSections.RemoveAt(i--);
                                    }
                                }
                                catch
                                {
                                    // ignored
                                }
                            }

                            // Add section to collection.
                            foreach (var section in tempSections)
                            {
                                try
                                {
                                    Add(section);
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
        /// Check if products with certain name in section product list exists.
        /// </summary>
        public static void CheckProducts()
        {
            try
            {
                foreach (var section in Sections)
                {
                    for (var i = 0; i < section.Products.Count; i++)
                    {
                        try
                        {
                            // Remove name if certain product does not exist.
                            if (!ProductManager.NameContains(section.Products[i], section.Path))
                            {
                                section.Products.RemoveAt(i--);
                            }
                        }
                        catch
                        {
                            // ignored
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
        public static void Clear() => Sections.Clear();
    }
}