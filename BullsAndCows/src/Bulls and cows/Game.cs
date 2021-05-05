using System;
using System.Collections.Generic;
using static System.Console;

namespace BullsAndCows
{
    partial class Program
    {
        /// <summary>
        /// Метод возвращает число, введенное пользователем.
        /// </summary>
        /// <param name="numberSize">Максимально возможный размер пользовательского числа.</param>
        /// <returns>Возвращает число, введенное пользователем.</returns>
        private static int InputUserNumber(int numberSize)
        {
            int userNumber;
            bool userNumberTryParseResult;

            do
            {
                Clear();

                Write("Введите свое число: ");

                userNumberTryParseResult = int.TryParse(ReadLine(), out userNumber);
                if (!userNumberTryParseResult | userNumber < Math.Pow(10, numberSize - 1) - 1 |
                    userNumber > Math.Pow(10, numberSize) + 1)
                {
                    WriteLine("Введены некорректные данные.");
                    WriteLine("\nДля продолжения нажмите любую клавишу, для выхода в главное меню - Esc...");
                    if (ReadKey(true).Key==ConsoleKey.Escape)
                    {
                        MainMenu();
                    }

                }
            } while (!userNumberTryParseResult | userNumber < Math.Pow(10, numberSize - 1) - 1 |
                     userNumber > Math.Pow(10, numberSize) + 1);

            return userNumber;
        }

        /// <summary>
        /// Метод возвращает размер создаваемого числа согласно пользовательскому вводу.
        /// </summary>
        /// <returns>Возвращение размера создаваемого числа</returns>
        private static int InputNumberSize()
        {
            bool numberSizeTryParseResult;

            int numberSize;

            do
            {
                Clear();
                Write("Укажите количество цифр(от 1 до 10) числа, которое будет загадано: ");

                numberSizeTryParseResult = int.TryParse(ReadLine(), out numberSize);

                if (!numberSizeTryParseResult | numberSize < 1 | numberSize > 10)
                {
                    WriteLine("Введены некорректные данные.");
                    WriteLine("\nДля продолжения нажмите любую клавишу...");
                    ReadKey();
                }
            } while (!numberSizeTryParseResult | numberSize < 1 | numberSize > 10);

            return numberSize;
        }

        /// <summary>
        /// Метод возвращает сгенирированное число в виде списка цифр.
        /// </summary>
        /// <param name="numOfDigits">Количество цифр числа</param>
        /// <returns>Возвращение сгенирированного числа в виде списка цифр.</returns>
        private static List<int> GenerateNumberAsDigitsList(int numOfDigits)
        {
            var listOfDigits = new List<int>();

            for (var i = 0; i < numOfDigits; i++)
            {
                if (numOfDigits == 1)
                {
                    listOfDigits.Add(rand.Next(0, 10));
                    break;
                }

                int generatedDigit;

                do
                {
                    generatedDigit = rand.Next(i == 0 ? 1 : 0, 10);
                } while (listOfDigits.Contains(generatedDigit));

                listOfDigits.Add(generatedDigit);
            }

            return listOfDigits;
        }

        /// <summary>
        /// Метод возвращает пользовательское число в виде списка цифр.
        /// </summary>
        /// <param name="number">Пользовательское число</param>
        /// <returns>Возвращение пользовательского числа в виде списка цифр.</returns>
        private static List<int> NumberToDigitsList(int number)
        {
            var listOfDigits = new List<int>();

            while (number > 0)
            {
                listOfDigits.Add(number % 10);
                number /= 10;
            }

            listOfDigits.Reverse();

            return listOfDigits;
        }

        /// <summary>
        /// Метод возвращает количество "коров" и "быков" в виде списка,
        /// сравнивая элементы списков цифр сгенирированного и пользовательского чисел. 
        /// </summary>
        /// <param name="generatedNumber">Список цифр сгенирированного числа</param>
        /// <param name="userNumber">Список цифр пользовательского числа</param>
        /// <returns>Возвращение количества "коров" и "быков" в виде списка.</returns>
        private static List<int> CountBullsAndCows(List<int> generatedNumber, List<int> userNumber)
        {
            var cows = 0;
            var bulls = 0;

            for (var i = 0; i < userNumber.Count; i++)
            {
                for (var j = 0; j < generatedNumber.Count; j++)
                {
                    if (userNumber[i] == generatedNumber[j])
                    {
                        if (i == j)
                        {
                            bulls++;
                        }
                        else
                        {
                            cows++;
                        }
                    }
                }
            }

            return new List<int> { bulls, cows };
        }
    }
}
