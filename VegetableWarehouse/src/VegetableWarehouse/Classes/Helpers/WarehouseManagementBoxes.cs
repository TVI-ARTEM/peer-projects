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
        #region ConsoleMethods

        /// <summary>
        /// Add new boxes to current container.
        /// </summary>
        /// <param name="container">Current container.</param>
        private static void AddBoxesByConsole(ref Container container)
        {
            // Help message.
            Message.PrintCurrentContainer(container);
            Message.BackToPreviousMenu();

            int containerNumberOfBoxesValue;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Write("Enter number of boxes: ");

                Console.ResetColor();

                var containerNumberOfBoxesInput = Console.ReadLine();

                if (containerNumberOfBoxesInput?.Trim().ToLower() == "quit") return;
                if (int.TryParse(containerNumberOfBoxesInput, out containerNumberOfBoxesValue)) break;
            } while (true);

            // Add new box to current container.
            for (var i = 0; i < containerNumberOfBoxesValue; i++)
            {
                CreateBoxByConsole(ref container);
            }
        }

        /// <summary>
        /// Create new box and add it to current container by console.
        /// </summary>
        /// <param name="container"></param>
        private static void CreateBoxByConsole(ref Container container)
        {
            try
            {
                var box = CreateBoxByConsoleInternal();

                box.Id = container.NumberOfBoxes + 1;

                container.AddNewBox(box);
            }
            catch (BoxException exception)
            {
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
                CreateBoxByConsole(ref container);
            }
            catch (Exception exception)
            {
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
                CreateBoxByConsole(ref container);
            }
        }

        /// <summary>
        /// Internal method for creation new box by console.
        /// </summary>
        /// <returns>Created box.</returns>
        private static Box CreateBoxByConsoleInternal()
        {
            // Help messages.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCreating new box...");

            Message.PrintVegetables();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Select vegetable: ");

            Console.ResetColor();

            var boxName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter box weight: ");

            Console.ResetColor();

            var boxWeightInput = Console.ReadLine();
            var boxWeightValue = int.Parse(boxWeightInput!);

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter box price for one kg: ");

            Console.ResetColor();

            var boxPriceInput = Console.ReadLine();
            var boxPriceValue = double.Parse(
                boxPriceInput!.Replace(',', '.'),
                NumberStyles.Any,
                CultureInfo.InvariantCulture
            );
            // Creation new box by user choices.
            return new Box(boxName, boxWeightValue, boxPriceValue);
        }

        /// <summary>
        /// Remove boxes from current container.
        /// </summary>
        /// <param name="container">Current container.</param>
        private static void RemoveBoxesByConsole(ref Container container)
        {
            do
            {
                int boxId;
                // Select necessary box's id.
                do
                {
                    Message.PrintCurrentContainer(container);
                    Message.PrintBoxes(container);

                    if (container.NumberOfBoxes == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter any key.");
                        Console.ReadKey();
                        Console.ResetColor();
                        return;
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.Write("Enter id of box: ");

                    Console.ResetColor();
                } while (!int.TryParse(Console.ReadLine(), out boxId) || boxId < 1 || boxId > container.NumberOfBoxes);

                // Remove selected box from current container.
                container.RemoveBox(boxId);

                // Print again changed container.
                Message.PrintCurrentContainer(container);
                Message.PrintBoxes(container);

                // Check number of boxes to back to previous menu.
                if (container.NumberOfBoxes == 0) return;

                // Repeat actions.
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Enter ESC to back, another to continue...");

                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Change boxes' price in current container.
        /// </summary>
        /// <param name="container">Current contaioner.</param>
        private static void ChangeBoxesPriceByConsole(ref Container container)
        {
            do
            {
                int boxId;
                // Select necessary box's id.
                do
                {
                    Message.PrintCurrentContainer(container);
                    Message.PrintBoxes(container);

                    if (container.NumberOfBoxes == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter any key.");
                        Console.ReadKey();
                        Console.ResetColor();

                        return;
                    }


                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.Write("Enter id of box: ");

                    Console.ResetColor();
                } while (!int.TryParse(Console.ReadLine(), out boxId) || boxId < 1 || boxId > container.NumberOfBoxes);

                double newPrice;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.Write("Enter new price: ");

                    Console.ResetColor();
                } while (!double.TryParse(Console.ReadLine(), out newPrice) || newPrice < 0);

                // Change box's price for one kg.
                container[boxId].Price = newPrice;

                // Print again changed container.
                Message.PrintCurrentContainer(container);
                Message.PrintBoxes(container);

                // Repeat action.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter ESC to back, another to continue...");

                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        #endregion

        #region FileMethods

        /// <summary>
        /// Change boxes in current container by file's commands.
        /// </summary>
        /// <param name="container">Current container.</param>
        private static void ChangeBoxesFromFile(ref Container container)
        {
            try
            {
                Console.Clear();
                Message.PrintVegetables();
                Message.FormatFileBoxes();
                Message.BackToPreviousMenu();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter direct path to file: ");
                Console.ResetColor();

                var pathToFile = Console.ReadLine();

                if (pathToFile?.Trim().ToLower() == "quit") return;


                // Create and add new warehouse to list.
                ChangeBoxesFromFileInternal(ref container, pathToFile);
            }
            catch (Exception exception)
            {
                // Error message.
                Message.PrintErrorMessage(exception);
                Message.PrintRepeatingMessage();
            }
        }

        /// <summary>
        /// Internal method for changing boxes in current container by file's commands.
        /// </summary>
        /// <param name="container">Current container.</param>
        /// <param name="path">Path to file, which probably contains commands.</param>
        private static void ChangeBoxesFromFileInternal(ref Container container, string path)
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
                        case "add_box":
                        {
                            var boxName = query[1];
                            var boxWeight = int.Parse(query[2]);
                            var boxPrice = double.Parse(query[3],
                                NumberStyles.Any, CultureInfo.InvariantCulture);

                            container.AddNewBox(new Box(boxName, boxWeight, boxPrice));
                            break;
                        }
                        case "remove_box":
                        {
                            var boxId = int.Parse(query[1]);

                            container.RemoveBox(boxId);
                            break;
                        }
                        case "change_box_price":
                        {
                            var boxId = int.Parse(query[1]);
                            var newBoxPrice = double.Parse(query[2],
                                NumberStyles.Any, CultureInfo.InvariantCulture);

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