using System;
using System.Globalization;
using System.IO;
using System.Linq;
using VegetableWarehouse.Classes.Entities;
using VegetableWarehouse.Classes.Exceptions;

namespace VegetableWarehouse.Classes.Helpers
{
    public static partial class WarehouseManagement
    {
        /// <summary>
        /// Change selected container.
        /// </summary>
        /// <param name="container">Selected container.</param>
        private static void ChangeContainer(ref Container container)
        {
            // Help message.
            Message.PrintCurrentContainer(container);
            Message.ModifiersContainer();

            // Select modifier.
            int modifier;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Select modifier: ");

                Console.ResetColor();
            } while (!int.TryParse(Console.ReadLine(), out modifier) || modifier < 1 || modifier > 5);

            switch (modifier)
            {
                case 1:
                    AddBoxesByConsole(ref container);
                    return;
                case 2:
                    RemoveBoxesByConsole(ref container);
                    return;
                case 3:
                    ChangeBoxesPriceByConsole(ref container);
                    return;
                case 4:
                    ChangeBoxesFromFile(ref container);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter any key...");
                    Console.ReadKey();
                    return;
                case 5:
                    return;
            }
        }

        #region ConsoleMethods

        /// <summary>
        /// Add new containers to current warehouse.
        /// </summary>
        /// <param name="warehouse">Current warehouse.</param>
        private static void AddContainersByConsole(ref Warehouse warehouse)
        {
            // help message.
            Message.PrintCurrentWarehouse(warehouse);
            Message.BackToPreviousMenu();

            int warehouseNumberOfContainersValue;

            // Select number of containers. 
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter number of containers: ");

                Console.ResetColor();

                var warehouseNumberOfContainersInput = Console.ReadLine();

                if (warehouseNumberOfContainersInput?.Trim().ToLower() == "quit") return;
                if (int.TryParse(warehouseNumberOfContainersInput, out warehouseNumberOfContainersValue)) break;
            } while (true);

            Message.PrintCurrentWarehouse(warehouse);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Number of containers: {warehouseNumberOfContainersValue}");
            Console.ResetColor();

            // Adding new container to current warehouse.
            for (var i = 0; i < warehouseNumberOfContainersValue; i++)
            {
                CreateContainerByConsole(ref warehouse);
            }
        }

        /// <summary>
        /// Creation new container and add it to current warehouse by console.
        /// </summary>
        /// <param name="warehouse">Current warehouse.</param>
        private static void CreateContainerByConsole(ref Warehouse warehouse)
        {
            // Create empty container.
            Container container = null;

            try
            {
                // Creation(change) container.
                container = CreateContainerByConsoleInternal();

                // Check container for null to back.
                if (container == null) return;

                // Change container id.
                container.Id = warehouse.NumberOfContainers + 1;

                // Add container to current warehouse.
                warehouse.AddContainer(container);
            }
            catch (WarehouseException exception)
            {
                // Error message.
                Message.PrintErrorMessage(exception);


                // Removing first container from current warehouse and add new.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Removing first container...");
                warehouse.RemoveContainer(1);

                Console.WriteLine("Adding new container...");
                warehouse.AddContainer(container);

                Console.WriteLine("Enter any key.");

                Console.ReadKey();

                Console.ResetColor();
            }
            catch (ContainerException exception)
            {
                // Error message and repeat action.
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
                CreateContainerByConsole(ref warehouse);
            }
            catch (Exception exception)
            {
                // Error message and repeat action.
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
                CreateContainerByConsole(ref warehouse);
            }
        }

        /// <summary>
        /// Internal method for creation container by console. 
        /// </summary>
        /// <returns>Created container.</returns>
        private static Container CreateContainerByConsoleInternal()
        {
            // Help messages.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCreating new container...");

            var container = new Container();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Container max weight: {container.CurrentMaxWeight}kg");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter container number of boxes: ");

            Console.ResetColor();

            var containerNumberOfBoxesInput = Console.ReadLine();

            // Check variable for null to back.
            if (containerNumberOfBoxesInput?.Trim().ToLower() == "quit") return null;

            var containerNumberOfBoxesValue = int.Parse(containerNumberOfBoxesInput!);

            // Add new boxes.
            for (var i = 0; i < containerNumberOfBoxesValue; i++)
            {
                CreateBoxByConsole(ref container);
            }

            return container;
        }

        /// <summary>
        /// Change warehouse's containers.
        /// </summary>
        /// <param name="warehouse">Current warehouse.</param>
        private static void ChangeContainersByConsole(ref Warehouse warehouse)
        {
            do
            {
                int containerId;
                // Select necessary container's id.
                do
                {
                    Message.PrintCurrentWarehouse(warehouse);
                    Message.PrintContainers(warehouse);

                    if (warehouse.NumberOfContainers == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter any key.");
                        Console.ReadKey();
                        Console.ResetColor();
                        return;
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter id of container: ");
                    Console.ResetColor();
                } while (!int.TryParse(Console.ReadLine(), out containerId) || containerId < 1 ||
                         containerId > warehouse.NumberOfContainers);

                // Change container.
                var container = warehouse[containerId];
                ChangeContainer(ref container);

                // Print again changed containers.
                Message.PrintCurrentWarehouse(warehouse);
                Message.PrintContainers(warehouse);

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Enter ESC to back, another to continue...");

                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Remove containers from current warehouse.
        /// </summary>
        /// <param name="warehouse">Current warehouse.</param>
        private static void RemoveContainersByConsole(ref Warehouse warehouse)
        {
            do
            {
                int containerId;

                // Select necessary container's id.
                do
                {
                    Message.PrintCurrentWarehouse(warehouse);
                    Message.PrintContainers(warehouse);

                    if (warehouse.NumberOfContainers == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter any key.");
                        Console.ReadKey();
                        Console.ResetColor();
                        return;
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter id of container: ");
                    Console.ResetColor();
                } while (!int.TryParse(Console.ReadLine(), out containerId) || containerId < 1 ||
                         containerId > warehouse.NumberOfContainers);

                // Remove selected container.
                warehouse.RemoveContainer(containerId);

                // Print changed containers.
                Message.PrintCurrentWarehouse(warehouse);
                Message.PrintContainers(warehouse);

                if (warehouse.NumberOfContainers == 0) return;

                // Repeat actions.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter ESC to back, another to continue...");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Move selected container to another warehouse.
        /// </summary>
        /// <param name="warehouse">Current warehouse.</param>
        private static void MoveContainerToAnotherWarehouseByConsole(ref Warehouse warehouse)
        {
            try
            {
                // Check exists another warehouse.
                if (Warehouses.Count == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There are not any destination warehouse");
                    Console.ReadKey();
                    Console.ResetColor();
                    return;
                }


                Message.PrintWarehouses(Warehouses);

                int destinationWarehouseId;
                // Select necessary container's id.
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.Write($"Select destination warehouse id (id does not equal to {warehouse.Id}): ");

                    Console.ResetColor();
                } while (!int.TryParse(Console.ReadLine(), out destinationWarehouseId) || destinationWarehouseId < 1 ||
                         destinationWarehouseId > Warehouses.Count || destinationWarehouseId == warehouse.Id);

                var destinationWarehouse = Warehouses[destinationWarehouseId - 1];


                Message.PrintContainers(warehouse);

                int sourceContainerId;
                // Select destination warehouse's id.
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Select source container to move: ");
                    Console.ResetColor();
                } while (!int.TryParse(Console.ReadLine(), out sourceContainerId) || sourceContainerId < 1 ||
                         sourceContainerId > warehouse.NumberOfContainers);

                // Move container to destination warehouse.
                warehouse.MoveContainerToAnotherWarehouse(sourceContainerId, destinationWarehouse);
            }
            catch (Exception exception)
            {
                // Error message.
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
            }
        }

        #endregion

        #region FileMethods

        /// <summary>
        /// Change containers in current warehouse by file's commands.
        /// </summary>
        /// <param name="warehouse">Current warehouse.</param>
        private static void ChangeContainersFromFile(ref Warehouse warehouse)
        {
            try
            {
                Console.Clear();
                Message.PrintVegetables();
                Message.FormatFileContainers();
                Message.BackToPreviousMenu();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter direct path to file: ");
                Console.ResetColor();

                var pathToFile = Console.ReadLine();

                if (pathToFile?.Trim().ToLower() == "quit") return;


                // Create and add new warehouse to list.
                ChangeContainersFromFileInternal(ref warehouse, pathToFile);
            }
            catch (Exception exception)
            {
                // Error message.
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
            }
        }

        /// <summary>
        /// Internal methods for changing containers in current warehouse by file's commands.
        /// </summary>
        /// <param name="warehouse">Current warehouse</param>
        /// <param name="path">Path to file, which probably contains commands</param>
        private static void ChangeContainersFromFileInternal(ref Warehouse warehouse, string path)
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

                    var query = inputString.Split('|').Select(parameter => parameter.Trim()).ToArray();

                    switch (query?[0].ToLower())
                    {
                        // Check for correct command.
                        case "add_container":
                        {
                            var newContainer = new Container();
                            warehouse.AddContainer(newContainer);
                            break;
                        }
                        case "remove_container":
                        {
                            var containerId = int.Parse(query[1]);
                            warehouse.RemoveContainer(containerId);
                            break;
                        }
                        case "move_container":
                        {
                            var containerId = int.Parse(query[1]);
                            var warehouseId = int.Parse(query[2]);

                            var warehouseDestination = Warehouses[warehouseId - 1];

                            warehouse.MoveContainerToAnotherWarehouse(containerId, warehouseDestination);
                            break;
                        }
                        case "add_box":
                        {
                            var containerId = int.Parse(query[1]);
                            var boxName = query[2];
                            var boxWeight = int.Parse(query[3]);
                            var boxPrice = double.Parse(query[4],
                                NumberStyles.Any, CultureInfo.InvariantCulture);

                            warehouse[containerId].AddNewBox(new Box(boxName, boxWeight, boxPrice));
                            break;
                        }
                        case "remove_box":
                        {
                            var containerId = int.Parse(query[1]);
                            var boxId = int.Parse(query[2]);

                            warehouse[containerId].RemoveBox(boxId);
                            break;
                        }
                        case "change_box_price":
                        {
                            var containerId = int.Parse(query[1]);
                            var boxId = int.Parse(query[2]);
                            var newBoxPrice = double.Parse(query[2],
                                NumberStyles.Any, CultureInfo.InvariantCulture);

                            var container = warehouse[containerId];

                            container[boxId].Price = newBoxPrice;

                            break;
                        }
                        default:
                            throw new InvalidOperationException("Unknown command.");
                    }
                }
                catch (Exception exception)
                {
                    Message.PrintErrorMessage(exception);
                }
            }
        }

        #endregion
    }
}