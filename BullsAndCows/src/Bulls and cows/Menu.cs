using System;
using static System.Console;

namespace BullsAndCows
{
    partial class Program
    {
        /// <summary>
        /// Метод входа в главное меню.
        /// </summary>
        private static void MainMenu()
        {
            int selectedMenuItem;
            bool selectedMenuItemTryParseResult;

            do
            {
                Clear();
                WriteLine("######################################");
                WriteLine("# Главное меню игры \"Быки и коровы\"! #");
                WriteLine("#------------------------------------#\n");
                WriteLine("1.Начать игру    2.Правила    3.Выход");

                selectedMenuItemTryParseResult = int.TryParse(ReadLine(), out selectedMenuItem);

                if (!selectedMenuItemTryParseResult | selectedMenuItem < 1 | selectedMenuItem > 3)
                {
                    WriteLine("Введены некорректные данные.");
                    WriteLine("\nДля продолжения нажмите любую клавишу...");
                    ReadKey();
                }
            } while (!selectedMenuItemTryParseResult | selectedMenuItem < 1 | selectedMenuItem > 3);

            switch (selectedMenuItem)
            {
                case 1:
                    StartGame(); //Переход к основному процессу игры.
                    break;
                case 2:
                    RulesOfGame(); //Переход к правилам игры.
                    break;
                case 3:
                    Environment.Exit(0); // Выход из игры.
                    break;
            }
        }

        /// <summary>
        /// Метод запускает основной процесс игры.
        /// </summary>
        private static void StartGame()
        {
            //Выбор размера числа
            var numberSize = InputNumberSize();

            //Представление сгенирированного числа в виде списка цифр.
            var generatedNumberAsDigitList = GenerateNumberAsDigitsList(numberSize);

            WriteLine("\nЧисло загадано! Попробуйте теперь угадать.");
            WriteLine("Для продолжения нажмите любую клавишу...");
            ReadKey();
            
            //Основной цикл игры
            while (true)
            {
                //Ввод пользовательского числа.
                var userNumber = InputUserNumber(numberSize);

                //Представление пользовательского числа в виде списка цифр.
                var userNumberAsDigitList = NumberToDigitsList(userNumber);

                //Подсчет количества "коров" и "быков".
                var result = CountBullsAndCows(generatedNumberAsDigitList, userNumberAsDigitList);

                if (result[0] == numberSize)
                {
                    WriteLine("Поздравляю!!!\nВы отгадали загаданное число.");

                    return;
                }

                WriteLine("К сожалению вы не отгадали число. Попробуйте снова.");
                WriteLine($"Количество быков {result[0]}, количество коров: {result[1]}");

                WriteLine("\nЧтобы выйти из игры нажмите ESC, для продолжения любую другую клавишу...");

                if (ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Метод предоставляет информацию о правилах игры.
        /// </summary>
        private static void RulesOfGame()
        {
            Clear();
            WriteLine("1. Пользователь вводит желаемый размер числа (количество цифр в загаданном числе).");
            WriteLine("2. Компьютер загадывает N-значное число, из неповторяющихся цифр");
            WriteLine("3. Пользователь, пытаясь угадать загаданное число, вводит N-значное число");
            WriteLine("*  Примечание   Пользователь может вводить число с одинаковыми цифрами");
            WriteLine("4. Компьютер выводит сообщение: количество быков (правильные цифры стоящие на своих местах) и " +
                      "\n   количество коров (правильные цифры стоящие не на своих местах).");
            WriteLine("5. Игра будет продолжаться до тех пор пока игрок не отгадает число, " +
                      "т.е не получит N быков,\n   где N - размерность числа");
            
            WriteLine("\nДля того чтобы вернуться в главное меню нажмите любуйю клавишу...");
            ReadKey();

            //Возвращает пользователя в главное меню
            MainMenu();
        }
    }
}
