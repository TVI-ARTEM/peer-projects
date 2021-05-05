using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using VegetableWarehouse.Classes.Entities;
using VegetableWarehouse.Classes.Exceptions;
using static System.Console;

namespace VegetableWarehouse.Classes.Helpers
{
    /// <summary>
    /// General class for warehouses management.
    /// </summary>
    public static partial class WarehouseManagement
    {
        /// <summary>
        /// List of created warehouses.
        /// </summary>
        private static readonly List<Warehouse> Warehouses;


        /// <summary>
        /// Static constructor for initialize List Warehouses.
        /// </summary>
        static WarehouseManagement()
        {
            Warehouses = new List<Warehouse>();
        }


        #region StartProgram

        /// <summary>
        /// Start program.
        /// </summary>
        public static void StartProgram()
        {
            Message.SayHello();

            MainMenu();
        }

        /// <summary>
        /// Program's main menu.
        /// </summary>
        private static void MainMenu()
        {
            while (true)
            {
                Message.MainMenu();

                int modifier;

                // Select modifier.
                do
                {
                    Message.MainMenu();

                    ForegroundColor = ConsoleColor.Green;
                    Write("Select modifier: ");
                    ResetColor();
                } while (!int.TryParse(ReadLine(), out modifier) || modifier < 1 || modifier > 5);

                switch (modifier)
                {
                    case 1:
                        CreateWarehouseByConsole();
                        break;
                    case 2:
                        CreateWarehouseFromFile();
                        break;
                    case 3:
                        ManageWarehouses();
                        break;
                    case 4:
                        Message.Info();
                        break;
                    default:
                        ForegroundColor = ConsoleColor.Cyan;
                        WriteLine("\nGoodbye!");

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("Enter any key...");
                        ReadKey();

                        return;
                }
                // Repeat actions.
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Enter any key...");
                ReadKey();
            }
        }

        #endregion
    }
}