using System;
using System.Linq;
using ProjectLibrary;
using static System.Console;


namespace TaskManagerConsole.Classes
{
    public static partial class Manager
    {
        /// <summary>
        /// Manage users method.
        /// </summary>
        private static void ManageUsers()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(ManageUsers);

            while (true)
                try
                {
                    ManageUsersGui();

                    if (!uint.TryParse(ReadLine(), out var command))
                        throw new ArgumentException("Incorrect input.");

                    switch (command)
                    {
                        case 1:
                            ShowUsers();
                            return;
                        case 2:
                            HireNewUser();
                            return;
                        case 3:
                            FireNewUser();
                            return;
                        case 4:
                            ReturnBack();
                            return;
                        default:
                            throw new ArgumentException("Incorrect input.");
                    }
                }
                catch (Exception exception)
                {
                    if (PrintErrorMessage(exception)) return;
                }
        }

        /// <summary>
        /// Manage users gui.
        /// </summary>
        private static void ManageUsersGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("1. Show users");
            WriteLine("2. Hire new user");
            WriteLine("3. Fire user");
            WriteLine("4. Back");

            WriteLine();
            ForegroundColor = ConsoleColor.Green;

            Write("Select command: ");
            ResetColor();
        }

        /// <summary>
        /// Show all users method.
        /// </summary>
        private static void ShowUsers()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(ShowUsers);

            while (true)
                try
                {
                    ShowUsersGui();

                    ReturnBack();
                    return;
                }
                catch (Exception exception)
                {
                    if (PrintErrorMessage(exception)) return;
                }
        }

        /// <summary>
        /// Show users gui.
        /// </summary>
        private static void ShowUsersGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            if (Users.Count == 0) throw new Exception("There are no users.");

            PrintArray(Users);

            WriteLine();
            ForegroundColor = ConsoleColor.Green;

            WriteLine("Enter any key...");
            ReadKey();
            ResetColor();
        }

        /// <summary>
        /// Hire new user method.
        /// </summary>
        private static void HireNewUser()
        {
            PreviousMethods.Add(HireNewUser);

            while (true)
                try
                {
                    HireNewUserGui();

                    var newUser = new User(ReadLine());

                    if (Users.Any(us => us.Name.Equals(newUser.Name)))
                        throw new ArgumentException("This user has already been hired");

                    Users.Add(newUser);

                    ReturnBack();
                    return;
                }
                catch (Exception exception)
                {
                    if (PrintErrorMessage(exception)) return;
                }
        }

        /// <summary>
        /// Here new user gui.
        /// </summary>
        private static void HireNewUserGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("Enter a name of new user");
            ForegroundColor = ConsoleColor.Green;

            Write("Name: ");
            ResetColor();
        }

        /// <summary>
        /// Fire new user method.
        /// </summary>
        private static void FireNewUser()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(FireNewUser);

            while (true)
                try
                {
                    FireNewUserGui();

                    if (!uint.TryParse(ReadLine(), out var userId))
                        throw new ArgumentException("Incorrect input.");

                    if (userId == Users.Count + 1)
                    {
                        ReturnBack();
                        return;
                    }

                    // Remove user from all tasks.
                    foreach (var project in Projects) RemoveUserFromTask(project, Users[(int) (userId - 1)]);

                    Users.Remove(Users[(int) (userId - 1)]);

                    ReturnBack();
                    return;
                }
                catch (Exception exception)
                {
                    if (PrintErrorMessage(exception)) return;
                }
        }

        /// <summary>
        /// Fire new user gui.
        /// </summary>
        private static void FireNewUserGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            if (Users.Count == 0) throw new Exception("There are no users.");

            PrintArray(Users);
            WriteLine($"{Users.Count + 1}. Back");
            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            Write("Select Id: ");
            ResetColor();
        }

        /// <summary>
        /// Remove user from all tasks.
        /// </summary>
        /// <param name="task">Checking task.</param>
        /// <param name="user">Removing user.</param>
        private static void RemoveUserFromTask(BaseTask task, User user)
        {
            (task as IAssignable)?.RemoveUser(user);

            var subTasks = (task as IManageable)?.Tasks;

            if (subTasks == null) return;

            foreach (var subTask in subTasks) RemoveUserFromTask(subTask, user);
        }
    }
}