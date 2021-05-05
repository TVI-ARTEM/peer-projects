using System;
using System.IO;

namespace WareHouse.Managers
{
    /// <summary>
    /// Class allow to save and load data.
    /// </summary>
    public class Manager
    {
        public const string AppPath = "Warehouse";
        public const string DataPath = "Save";
        public const string SavePath = "General";

        public static Random Random = new Random();

        /// <summary>
        /// Save all data.
        /// </summary>
        public static void Save(string folderName = SavePath)
        {
            // Create folder for data.
            var appDirectory = Directory.CreateDirectory(AppPath);
            appDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            appDirectory.CreateSubdirectory(folderName);
            appDirectory.CreateSubdirectory(Path.Combine(folderName, DataPath));

            ProductManager.Save(folderName);
            SectionManager.Save(folderName);
            CompanyManager.Save(folderName);
        }

        /// <summary>
        /// Load all data.
        /// </summary>
        public static void Load(string folderName = SavePath)
        {
            // Create folder for data.
            var appDirectory = Directory.CreateDirectory(AppPath);
            appDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            appDirectory.CreateSubdirectory(folderName);
            appDirectory.CreateSubdirectory(Path.Combine(folderName, DataPath));


            CompanyManager.Load(folderName);
            SectionManager.Load(folderName);
            ProductManager.Load(folderName);

            // Check data for valid.
            SectionManager.CheckProducts();
            ProductManager.CheckProducts();
        }

        public static void Clear()
        {
            ProductManager.Clear();
            SectionManager.Clear();
            CompanyManager.Clear();
        }

    }
}
