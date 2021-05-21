using System;
using System.IO;
using WareHouse.Entities;

namespace WareHouse.Managers
{
    /// <summary>
    /// Class allow to save and load data.
    /// </summary>
    public class Manager
    {
        public const string AppPath = "Warehouse";
        public const string DataPath = "Save";
        public const string SaveWarehousePath = "Warehouse";
        public const string SaveClientPath = "Client";

        public static Random Random = new Random();

        public static Client CurrentClient { get; set; }

        /// <summary>
        /// Save warehouse data.
        /// </summary>
        public static void SaveWarehouse()
        {
            // Create folder for data.
            var appDirectory = Directory.CreateDirectory(AppPath);
            appDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            appDirectory.CreateSubdirectory(SaveWarehousePath);
            appDirectory.CreateSubdirectory(Path.Combine(SaveWarehousePath, DataPath));
            appDirectory.CreateSubdirectory(SaveClientPath);
            appDirectory.CreateSubdirectory(Path.Combine(SaveClientPath, DataPath));

            ProductManager.Save(SaveWarehousePath);
            SectionManager.Save(SaveWarehousePath);
            CompanyManager.Save(SaveWarehousePath);
            ClientManager.Save(SaveClientPath);
            OrderManager.Save(SaveWarehousePath);
        }

        /// <summary>
        /// Load warehouse data.
        /// </summary>
        public static void LoadWarehouse()
        {
            // Create folder for data.
            var appDirectory = Directory.CreateDirectory(AppPath);
            appDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            appDirectory.CreateSubdirectory(SaveWarehousePath);
            appDirectory.CreateSubdirectory(Path.Combine(SaveWarehousePath, DataPath));
            appDirectory.CreateSubdirectory(SaveClientPath);
            appDirectory.CreateSubdirectory(Path.Combine(SaveClientPath, DataPath));


            CompanyManager.Load(SaveWarehousePath);
            SectionManager.Load(SaveWarehousePath);
            ProductManager.Load(SaveWarehousePath);
            ClientManager.Load(SaveClientPath);
            OrderManager.Load(SaveWarehousePath);
            // Check data for valid.
            SectionManager.CheckProducts();
            ProductManager.CheckProducts();
        }

        /// <summary>
        /// Save client data.
        /// </summary>
        public static void SaveClient()
        {
            // Create folder for data.
            var appDirectory = Directory.CreateDirectory(AppPath);
            appDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            appDirectory.CreateSubdirectory(SaveClientPath);
            appDirectory.CreateSubdirectory(Path.Combine(SaveClientPath, DataPath));


            ClientManager.Save(SaveClientPath);
        }

        /// <summary>
        /// Load client data.
        /// </summary>
        public static void LoadClient()
        {
            // Create folder for data.
            var appDirectory = Directory.CreateDirectory(AppPath);
            appDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            appDirectory.CreateSubdirectory(SaveClientPath);
            appDirectory.CreateSubdirectory(Path.Combine(SaveClientPath, DataPath));

            ClientManager.Load(SaveClientPath);
        }
    }
}