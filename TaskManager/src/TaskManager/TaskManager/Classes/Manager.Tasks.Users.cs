using System;
using ProjectLibrary;
using static System.Console;

namespace TaskManagerConsole.Classes
{
    public static partial class Manager
    {
        /// <summary>
        /// Add new user to current task.
        /// </summary>
        private static void AddUser()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(AddUser);

            while (true)
            {
                try
                {
                    AddUserGui();

                    if (!uint.TryParse(ReadLine(), out var userId))
                        throw new ArgumentException("Incorrect input.");
                    if (userId == Users.Count + 1)
                    {
                        ReturnBack();
                        return;
                    }

                    (CurrentTask as IAssignable)?.AddUser(Users[(int) userId - 1]);


                    ReturnBack();
                    return;
                }
                catch (Exception exception)
                {
                    if (PrintErrorMessage(exception)) return;
                }
            }
        }

        /// <summary>
        /// Add new user to current task gui.
        /// </summary>
        private static void AddUserGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            if (Users.Count == 0)
            {
                throw new Exception("There are no users.");
            }

            PrintArray(Users);
            WriteLine($"{Users.Count + 1}. Back");
            WriteLine();
            ForegroundColor = ConsoleColor.Green;

            Write("Select id: ");
            ResetColor();
        }

        /// <summary>
        /// Remove user from current task.
        /// </summary>
        private static void RemoveUser()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(RemoveUser);

            while (true)
            {
                try
                {
                    RemoveUserGui();

                    if (!uint.TryParse(ReadLine(), out var userId))
                        throw new ArgumentException("Incorrect input.");
                    if (userId == (CurrentTask as IAssignable)?.Users.Count + 1)
                    {
                        ReturnBack();
                        return;
                    }

                    (CurrentTask as IAssignable)?.RemoveUser(
                        (CurrentTask as IAssignable)?.Users[(int) userId - 1]);

                    ReturnBack();
                    return;
                }
                catch (Exception exception)
                {
                    if (PrintErrorMessage(exception)) return;
                }
            }
        }

        /// <summary>
        /// Remove user from current task gui.
        /// </summary>
        private static void RemoveUserGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;

            if ((CurrentTask as IAssignable)?.Users.Count == 0)
            {
                throw new Exception("There are no users.");
            }

            PrintArray((CurrentTask as IAssignable)?.Users);
            WriteLine($"{(CurrentTask as IAssignable)?.Users.Count + 1}. Back");
            WriteLine();
            ForegroundColor = ConsoleColor.Green;

            Write("Select id: ");
            ResetColor();
        }


        /// <summary>
        /// Show task's user.
        /// </summary>
        private static void ShowTaskUser()
        {
            PreviousMethods.Add(ShowTaskUser);

            while (true)
            {
                try
                {
                    ShowTaskUserGui();

                    ReturnBack();
                    return;
                }
                catch (Exception exception)
                {
                    if (PrintErrorMessage(exception)) return;
                }
            }
        }

        /// <summary>
        /// Show task's user gui.
        /// </summary>
        private static void ShowTaskUserGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;

            if ((CurrentTask as IAssignable)?.Users.Count == 0)
            {
                throw new Exception("There are no users.");
            }

            PrintArray((CurrentTask as IAssignable)?.Users);
            WriteLine();
            ForegroundColor = ConsoleColor.Green;

            Write("Enter any key...");
            ReadKey();
            ResetColor();
        }
    }

}