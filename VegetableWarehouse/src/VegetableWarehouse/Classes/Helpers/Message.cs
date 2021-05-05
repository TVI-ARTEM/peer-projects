using System;
using System.Collections.Generic;
using VegetableWarehouse.Classes.Entities;
using static System.Console;

namespace VegetableWarehouse.Classes.Helpers
{
    /// <summary>
    /// Class for print any message.
    /// </summary>
    public static class Message
    {
        #region ErrorMessage

        /// <summary>
        /// Print error message. 
        /// </summary>
        /// <param name="exception">Exception.</param>
        public static void PrintErrorMessage(Exception exception)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"Error: {exception.Message}");
            ResetColor();
        }

        /// <summary>
        /// Print repeating message.
        /// </summary>
        public static void PrintRepeatingMessage()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Let's try again...");
            ResetColor();

            ReadKey();
            WriteLine();
        }

        #endregion


        #region Modifiers

        /// <summary>
        /// Print warehouse modifiers. 
        /// </summary>
        public static void ModifiersWarehouse()
        {
            ForegroundColor = ConsoleColor.Cyan;

            WriteLine("Available modifiers:");
            WriteLine("1. Add new containers\n" + 
                      "2. Change containers\n" +
                      "3. Remove containers\n" +
                      "4. Move containers to another warehouse\n" +
                      "5. Change containers by file's commands\n" +
                      "6. Save warehouse info in file\n" +
                      "7. Exit");
            
            ResetColor();
            
            WriteLine();
        }

        /// <summary>
        /// Print container modifiers.
        /// </summary>
        public static void ModifiersContainer()
        {
            ForegroundColor = ConsoleColor.Cyan;

            WriteLine("Available modifiers:");
            WriteLine("1. Add new boxes\n" +
                      "2. Remove boxes\n" +
                      "3. Change box price\n" +
                      "4. Change boxes by file's commands\n" +
                      "5. Exit\n");

            
            ResetColor();
            
            WriteLine();
        }

        #endregion


        #region CreationMessages

        /// <summary>
        /// Print available cities.
        /// </summary>
        public static void PrintCities()
        {
            Clear();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Available cities:");

            ForegroundColor = ConsoleColor.Yellow;
            

            foreach (var city in Warehouse.Cities)
            {
                Write($"{city} ");
            }

            ResetColor();

            WriteLine();
        }

        /// <summary>
        /// Print available vegetables.
        /// </summary>
        public static void PrintVegetables()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Available vegetables:");

            ForegroundColor = ConsoleColor.Yellow;

            foreach (var vegetable in Box.Vegetables)
            {
                Write($"{vegetable} ");
            }

            ResetColor();

            WriteLine();
        }

        /// <summary>
        /// Print warehouse's containers info.
        /// </summary>
        /// <param name="warehouse">Current warehouse.</param>
        public static void PrintContainers(Warehouse warehouse)
        {
            ForegroundColor = ConsoleColor.Yellow;
            // Check warehouse's number of container for null.
            if (warehouse.NumberOfContainers==0)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("There are not any containers.");
            }
            else
            {
                WriteLine("Containers:");

                foreach (var container in warehouse.Containers)
                {
                    WriteLine(container);
                }
            }
            
            ResetColor();

            WriteLine();
        }

        /// <summary>
        /// Print container's boxes' info. 
        /// </summary>
        /// <param name="container">Current container.</param>
        public static void PrintBoxes(Container container)
        {
            ForegroundColor = ConsoleColor.Yellow;

            if (container.NumberOfBoxes == 0)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("There are not any containers.");
            }
            else
            {
                WriteLine("Boxes:");

                foreach (var box in container.Boxes)
                {
                    WriteLine(box);
                }
            }

            ResetColor();

            WriteLine();
        }

        /// <summary>
        /// Print exists warehouse.
        /// </summary>
        /// <param name="warehouses">List of warehouses.</param>
        public static void PrintWarehouses(List<Warehouse> warehouses)
        {
            ForegroundColor = ConsoleColor.Yellow;

            Clear();
            // Check number of warehouses for null.
            if (warehouses.Count == 0)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("There are not any warehouses.");
            }
            else
            {

                WriteLine("Exists warehouses:");

                foreach (var warehouse in warehouses)
                {
                    WriteLine(warehouse);
                }
            
                ResetColor();

                WriteLine();
            }
        }

        /// <summary>
        /// Print current warehouse's info.
        /// </summary>
        /// <param name="warehouse">Current warehouse.</param>
        public static void PrintCurrentWarehouse(Warehouse warehouse)
        {
            ForegroundColor = ConsoleColor.Yellow;

            Clear();
            WriteLine($"Current warehouse:\n{warehouse}");

            ResetColor();

            WriteLine();
        }

        /// <summary>
        /// Print current container's info.
        /// </summary>
        /// <param name="container">Current container.</param>
        public static void PrintCurrentContainer(Container container)
        {
            ForegroundColor = ConsoleColor.Yellow;

            Clear();
            WriteLine($"Current container:\n {container}");

            ResetColor();

            WriteLine();
        }

        #endregion


        #region UIMessages

        /// <summary>
        /// Say hello to user.
        /// </summary>
        public static void SayHello()
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Welcome to manager warehouses!!!");

            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter any key.");
            ReadKey();
            ResetColor();
        }

        /// <summary>
        /// Print UI message - commands.
        /// </summary>
        public static void MainMenu()
        {
            Clear();

            ForegroundColor = ConsoleColor.Cyan;

            WriteLine("Commands:");
            WriteLine("1. Create new warehouse (CONSOLE)\n" +
                      "2. Create new warehouse (FILE)\n" +
                      "3. Management warehouse\n" +
                      "4. Info\n" +
                      "5. Exit");
            
            ResetColor();

            WriteLine();
        }
        /// <summary>
        /// Print user's info.
        /// </summary>
        public static void Info()
        {
            PrintCities();
            PrintVegetables();
            FormatFileWarehouse();
            FormatFileContainers();
            FormatFileBoxes();

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Additional functions:\n" +
                      "1. Creating many warehouses\n" +
                      "2. Change box price\n" +
                      "3. Move container from source warehouse to destination\n" +
                      "4. Attractive interface:)");

            ResetColor();

            WriteLine();
        }

        /// <summary>
        /// Print string for back to previous menu.
        /// </summary>
        public static void BackToPreviousMenu()
        {
            ForegroundColor = ConsoleColor.Green;

            WriteLine("Input 'quit' and back to previous menu.");

            ResetColor();

            WriteLine();
        }

        #endregion


        #region FileMessages
        
        
        /// <summary>
        /// Print format file for creation new warehouse. 
        /// </summary>
        public static void FormatFileWarehouse()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine();
            WriteLine("Format warehouse's properties in file:");
            WriteLine();

            WriteLine("Open new warehouse:");
            WriteLine("<OPEN> | <City> | <MAX_NUMBER_OF_CONTAINERS> | <PERCENTAGE_FOR_STORAGE_COST>");
            WriteLine();

            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Examples:\nopen | moscow | 50 | 30 ");
            WriteLine();

            ResetColor();
        }

        /// <summary>
        /// Print format file for work with containers.
        /// </summary>
        public static void FormatFileContainers()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine();
            WriteLine("Format container's properties in file:");
            WriteLine();

            WriteLine("Add new empty container to current warehouse.");
            WriteLine("<ADD_CONTAINER>");
            WriteLine();

            WriteLine("Remove container from current warehouse.");
            WriteLine("<REMOVE_CONTAINER> | <CONTAINER_ID>");
            WriteLine();

            WriteLine("Move selected container from current warehouse to destination warehouse:");
            WriteLine("<MOVE_CONTAINER> | <CONTAINER_ID> | <DESTINATION_WAREHOUSE_ID>");
            WriteLine();

            WriteLine("Add new box to selected container in current warehouse.");
            WriteLine("<ADD_BOX> | <CONTAINER_ID> | <NAME_VEGETABLE> | <BOX_WEIGHT> | <BOX_PRICE>");
            WriteLine();

            WriteLine("Remove box from selected container in current warehouse.");
            WriteLine("<REMOVE_BOX> | <CONTAINER_ID> | <BOX_ID>");
            WriteLine();

            WriteLine("Change box's price in selected container in current warehouse.");
            WriteLine("<CHANGE_BOX_PRICE> | <CONTAINER_ID> | <BOX_ID> | <NEW_BOX_PRICE>");
            WriteLine();

            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Examples:\nadd_box | 2 | potato | 20 | 1.05");
            WriteLine();
            
            ResetColor();
        }

        /// <summary>
        /// Print format file for work with boxes.
        /// </summary>
        public static void FormatFileBoxes()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine();
            WriteLine("Format box's properties in file:");
            WriteLine();

            WriteLine("Add new box to current container.");
            WriteLine("<ADD_BOX> | <NAME_VEGETABLE> | <BOX_WEIGHT> | <BOX_PRICE>");
            WriteLine();

            WriteLine("Remove box from current container.");
            WriteLine("<REMOVE_BOX> | <BOX_ID>");
            WriteLine();

            WriteLine("Change box price for one kg in current container");
            WriteLine("<CHANGE_BOX_PRICE> | <BOX_ID> | <NEW_BOX_PRICE>");
            WriteLine();

            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Examples:\nadd_box | potato | 20 | 1.05");
            WriteLine();

            ResetColor();
        }

        #endregion
    }
}