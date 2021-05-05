using System;
using System.IO;
using System.Linq;
using VegetableWarehouse.Classes.Entities;
using VegetableWarehouse.Classes.Exceptions;

namespace VegetableWarehouse.Classes.Helpers
{
    public static partial class WarehouseManagement
    {
        #region ConsoleMethods

        /// <summary>
        /// Create new warehouse from console.
        /// </summary>
        private static void CreateWarehouseByConsole()
        {
            try
            {
                // Create new warehouse.
                var warehouse = CreateWarehouseByConsoleInternal();

                // Check for null to back.
                if (warehouse == null) return;

                // Add new warehouse to list.
                Warehouses.Add(warehouse);
            }
            catch (WarehouseException exception)
            {
                // Error message and repeat actions.
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
                CreateWarehouseByConsole();
            }
            catch (Exception exception)
            {
                // Error message and repeat actions.
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
                CreateWarehouseByConsole();
            }
        }

        /// <summary>
        /// Internal method for creation new warehouse from console.
        /// </summary>
        /// <returns></returns>
        private static Warehouse CreateWarehouseByConsoleInternal()
        {
            // Help message.
            Message.PrintCities();
            Message.BackToPreviousMenu();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Select warehouse city: ");
            Console.ResetColor();

            var warehouseCity = Console.ReadLine();

            // Check for null to back.
            if (warehouseCity?.Trim().ToLower() == "quit") return null;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter warehouse max number of containers: ");
            Console.ResetColor();

            var warehouseMaxNumberOfContainerInput = Console.ReadLine();

            // Check for null to back.
            if (warehouseMaxNumberOfContainerInput?.Trim().ToLower() == "quit") return null;

            var warehouseMaxNumberOfContainerValue = int.Parse(warehouseMaxNumberOfContainerInput!);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter warehouse percentage (percentage of the total cost of the containment container): ");
            Console.ResetColor();

            var percentStorageCostInput = Console.ReadLine();

            // Check for null to back.
            if (percentStorageCostInput?.Trim().ToLower() == "quit") return null;

            var percentStorageCostValue = int.Parse(percentStorageCostInput!);


            var id = Warehouses.Count + 1;

            // Creation new warehouse by user choices. 
            return new Warehouse(id, warehouseCity, warehouseMaxNumberOfContainerValue, percentStorageCostValue);
        }

        #endregion

        #region FileMethods

        /// <summary>
        /// Create new warehouse from file and add to list..
        /// </summary>
        private static void CreateWarehouseFromFile()
        {
            try
            {
                Message.PrintCities();
                Message.FormatFileWarehouse();
                Message.BackToPreviousMenu();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter direct path to file: ");
                Console.ResetColor();

                var pathToFile = Console.ReadLine();

                if (pathToFile?.Trim().ToLower() == "quit") return;


                // Create and add new warehouse to list.
                CreateWarehouseFromFileInternal(pathToFile);
            }
            catch (Exception exception)
            {
                // Error message.
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
            }
        }

        /// <summary>
        /// Internal method for creation new warehouse from file and add to list.
        /// </summary>
        /// <param name="path">Path to file, which probably contains info about warehouse.</param>
        private static void CreateWarehouseFromFileInternal(string path)
        {
            // Check file for exists.
            if (!File.Exists(path))
            {
                throw new Exception("Incorrect path");
            }

            // Check file's extension for correct.
            if (!path.Contains(".txt"))
            {
                throw new Exception("Incorrect file extension");
            }

            // Reading file.
            using var sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                try
                {
                    var inputString = sr.ReadLine();

                    if (string.Equals(inputString, string.Empty, StringComparison.InvariantCultureIgnoreCase)) continue;

                    var query = inputString?.Split('|').Select(parameter => parameter.Trim()).ToArray();

                    // Check for correct command.
                    if (query?[0].ToLower() == "open")
                    {
                        var id = Warehouses.Count + 1;

                        var warehouse = new Warehouse(id, query[1], int.Parse(query[2]), int.Parse(query[3]));

                        Warehouses.Add(warehouse);
                    }
                    else
                    {
                        throw new InvalidOperationException("Unknown command.");
                    }
                }
                catch (Exception exception)
                {
                    Message.PrintErrorMessage(exception);
                }
            }
        }

        /// <summary>
        /// Save current warehouse's info in file.
        /// </summary>
        /// <param name="warehouse">Current warehouse.</param>
        private static void SaveWarehouseInfo(ref Warehouse warehouse)
        {
            try
            {
                Message.BackToPreviousMenu();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter direct path to file: ");
                Console.ResetColor();

                var pathToFile = Console.ReadLine();

                if (pathToFile?.Trim().ToLower() == "quit") return;

                // Check file for exists.
                if (File.Exists(pathToFile))
                {
                    throw new Exception("File already exists.");
                }

                // Check file's extension for correct.
                if (!pathToFile.Contains(".txt"))
                {
                    throw new Exception("Incorrect file extension");
                }

                var warehouseInfo = warehouse + Environment.NewLine + Environment.NewLine;

                foreach (var container in warehouse.Containers)
                {
                    warehouseInfo += container + Environment.NewLine;

                    warehouseInfo = container.Boxes.Aggregate(warehouseInfo,
                        (currentString, box) => currentString + (box + Environment.NewLine));

                    warehouseInfo += Environment.NewLine;
                }

                File.WriteAllText(pathToFile, warehouseInfo);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully save!");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter any key...");
                Console.ReadKey();

                Console.ResetColor();
            }
            catch (Exception exception)
            {
                // Error message.
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
            }
        }

        #endregion

        /// <summary>
        /// Manage warehouses. 
        /// </summary>
        private static void ManageWarehouses()
        {
            do
            {
                int warehouseId;
                // Select necessary warehouse.
                do
                {
                    Message.PrintWarehouses(Warehouses);

                    if (Warehouses.Count == 0) return;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter id of warehouse: ");
                    Console.ResetColor();
                } while (!int.TryParse(Console.ReadLine(), out warehouseId) || warehouseId < 1 ||
                         warehouseId > Warehouses.Count);

                // Manage selected warehouse.
                var warehouse = Warehouses[warehouseId - 1];

                ManageWarehouse(ref warehouse);

                // Print again info about warehouses.
                Message.PrintWarehouses(Warehouses);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter ESC to back, another to continue...");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Manage warehouse.
        /// </summary>
        /// <param name="warehouse">Selected warehouse for manage.</param>
        private static void ManageWarehouse(ref Warehouse warehouse)
        {
            do
            {
                int modifier;
                // Select modifier.
                do
                {
                    Message.PrintCurrentWarehouse(warehouse);
                    Message.ModifiersWarehouse();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Select modifier: ");
                    Console.ResetColor();
                } while (!int.TryParse(Console.ReadLine(), out modifier) || modifier < 1 || modifier > 7);

                switch (modifier)
                {
                    case 1:
                        AddContainersByConsole(ref warehouse);
                        break;
                    case 2:
                        ChangeContainersByConsole(ref warehouse);
                        break;
                    case 3:
                        RemoveContainersByConsole(ref warehouse);
                        break;
                    case 4:
                        MoveContainerToAnotherWarehouseByConsole(ref warehouse);
                        break;
                    case 5:
                        ChangeContainersFromFile(ref warehouse);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enter any key...");
                        Console.ReadKey();
                        break;
                    case 6:
                        SaveWarehouseInfo(ref warehouse);
                        break;
                    case 7:
                        return;
                }

                // Print again changed warehouse.
                Message.PrintCurrentWarehouse(warehouse);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter ESC to back, another to continue...");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}