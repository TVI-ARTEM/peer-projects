using System;
using static System.Console;

namespace BullsAndCows
{
    partial class Program
    {
        private static Random rand = new Random();

        private static void Main(string[] args)
        {
            do
            {
                Title = "Bulls and Cows";
                Clear();
                WriteLine("############################################");
                WriteLine("# Добро пожаловать в игру \"Быки и коровы\"! #");
                WriteLine("#------------------------------------------#");
                WriteLine("\nНажмите любую клавишу...");
                ReadKey();
                
                // Вход в главное меню.
                MainMenu();

                WriteLine("\nДля выхода нажмите ESC, для повтора любую другую клавишу...");
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}