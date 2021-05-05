using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Newtonsoft.Json;
using ProjectLibrary;
using static System.Console;

namespace TaskManagerConsole.Classes
{
    public static partial class Manager
    {
        /// <summary>
        /// Static constructor to initialize some data.
        /// </summary>
        static Manager()
        {
            Users = new List<User>();
            Projects = new List<Project>();
            PreviousMethods = new List<Action>();
            ApplicationLoad();
            StartGui();
        }

        public const string ManagerPath = "TaskManager";
        public const string SettingsPath = "Settings";
        public const string ProjectsFile = "Projects.txt";
        public const string UsersFile = "Users.txt";
        public const string ProjectSeparator = "**=EndProject=**";
        public const string UserSeparator = "**=EndUser=**";

        /// <summary>
        /// List of current user.
        /// </summary>
        public static List<User> Users { get; }

        /// <summary>
        /// List of current projects.
        /// </summary>
        public static List<Project> Projects { get; }

        /// <summary>
        /// List of previous actions.
        /// </summary>
        public static List<Action> PreviousMethods;

        /// <summary>
        /// Current task).
        /// </summary>
        public static BaseTask CurrentTask;

        /// <summary>
        /// Method when application start.
        /// </summary>
        private static void StartGui()
        {
            var consoleColors = new[]
            {
                ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan,
                ConsoleColor.Red, ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.Blue, ConsoleColor.Yellow
            };

            foreach (var color in consoleColors)
            {
                ForegroundColor = color;
                Clear();
                WriteLine("█████████████████████");
                WriteLine("██░░░░░░░░░░░░░░░░░██");
                WriteLine("██░░░║║╔╗╗╔╔╗░╔╗░░░██");
                WriteLine("██░░░╠╣╔╣║║╠╝░╔╣░░░██");
                WriteLine("██░░░║║╚╝╚╝╚╝░╚╝░░░██");
                WriteLine("██░░░░░░░░░░░░░░░░░██");
                WriteLine("██░░░░╔╗╗╦╔╔╗╔╗╬░░░██");
                WriteLine("██░░░░╚╗║║║╠╝╠╝║░░░██");
                WriteLine("██░░░░╚╝╚╩╝╚╝╚╝╚░░░██");
                WriteLine("██░░░░░░░░░░░░░░░║░██");
                WriteLine("██░║║║╔╗╔╗║╔╔╗╔╗╔╣░██");
                WriteLine("██░║║║╠╝╠╝╠╣╠╝║║║║░██");
                WriteLine("██░╚╩╝╚╝╚╝║╚╚╝║║╚╝░██");
                WriteLine("██░░░░░░░░░░░░░░░░░██");
                WriteLine("█████████████████████");
                Thread.Sleep(300);
            }

            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter any key...");
            ResetColor();
            ReadKey();
        }

        /// <summary>
        /// Main menu.
        /// </summary>
        public static void MainMenu()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(MainMenu);

            while (true)
            {
                try
                {
                    MainMenuGui();
                    if (!uint.TryParse(ReadLine(), out var command)) throw new ArgumentException("Incorrect input.");
                    switch (command)
                    {
                        case 1:
                            ManageProjects();
                            return;
                        case 2:
                            ManageUsers();
                            return;
                        case 3:
                            Help();
                            return;
                        case 4:
                            SaveData();
                            return;
                        default:
                            throw new ArgumentException("Incorrect input.");
                    }
                }
                catch (Exception exception)
                {
                    WriteLine(exception.Message);
                    WriteLine("Enter any key...");
                    ReadKey();
                }
            }
        }

        /// <summary>
        /// Main menu gui.
        /// </summary>
        private static void MainMenuGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("1. Manage projects");
            WriteLine("2. Manage users");
            WriteLine("3. Help");
            WriteLine("4. Exit");

            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            Write("Select command: ");
            ResetColor();
        }

        /// <summary>
        /// Print message of exception.
        /// </summary>
        /// <param name="exception">Certain exception.</param>
        /// <returns>User choice.</returns>
        private static bool PrintErrorMessage(Exception exception)
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine(exception.Message);
            WriteLine("Enter ESC - to back, another - to repeat...");

            ResetColor();

            if (ReadKey(true).Key != ConsoleKey.Escape) return false;

            ReturnBack();
            return true;
        }

        /// <summary>
        /// Return to previous method.
        /// </summary>
        private static void ReturnBack()
        {
            SaveData();
            SortTasks();
            if (PreviousMethods.Count < 2) return;

            // Choose previous method and start it.
            var thisPreviousMethod = PreviousMethods[^2];
            PreviousMethods.RemoveRange(PreviousMethods.Count - 2, 2);
            thisPreviousMethod?.Invoke();
        }

        /// <summary>
        /// Sort tasks by task's state.
        /// </summary>
        private static void SortTasks()
        {
            (CurrentTask as IManageable)?.Tasks.Sort((x, y) =>
            {
                if (x.State < y.State) return -1;
                return 1;
            });

            Projects.Sort((x, y) =>
            {
                if (x.State < y.State) return -1;
                return 1;
            });
        }

        /// <summary>
        /// Help method.
        /// </summary>
        private static void Help()
        {
            Clear();
            PreviousMethods.Add(Help);
            ForegroundColor = ConsoleColor.Blue;

            WriteLine("Thanks for using!");
            WriteLine("Version: 0.9");
            WriteLine("Company: Hse");
            WriteLine("Help please!");

            ForegroundColor = ConsoleColor.Green;

            WriteLine("Enter any key...");
            ResetColor();

            ReadKey();

            ReturnBack();
        }

        /// <summary>
        /// Print certain list.
        /// </summary>
        /// <typeparam name="T">List type.</typeparam>
        /// <param name="list">Certain type.</param>
        private static void PrintArray<T>(IEnumerable<T> list)
        {
            var id = 0;
            foreach (var item in list)
            {
                WriteLine($"{++id}. {item}");
            }

            WriteLine();
        }

        /// <summary>
        /// Save certain data list to file.
        /// </summary>
        /// <typeparam name="T">List type.</typeparam>
        /// <param name="filePath">File path.</param>
        /// <param name="separator">File separator.</param>
        private static void SaveFile<T>(string filePath, string separator)
        {
            try
            {
                // Set up json option.
                var options = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All,
                    PreserveReferencesHandling = PreserveReferencesHandling.All,
                    Formatting = Formatting.Indented
                };

                var objectsInfo = string.Empty;

                // Choose list.
                dynamic array = typeof(T) == typeof(User) ? Users : typeof(T) == typeof(Project) ? Projects : null;

                if (array != null)
                {
                    foreach (var item in array)
                    {
                        // Serialize object and add it to result string. 
                        objectsInfo += JsonConvert.SerializeObject(item, options);
                        objectsInfo += Environment.NewLine + separator + Environment.NewLine;
                    }
                }

                // Save file.
                using var fileStream = new FileStream(Path.Combine(ManagerPath, SettingsPath, filePath),
                    FileMode.Create,
                    FileAccess.Write);
                using var streamWriter = new StreamWriter(fileStream);

                streamWriter.WriteLine(objectsInfo);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Save certain data.
        /// </summary>
        private static void SaveData()
        {
            SaveFile<User>(UsersFile, UserSeparator);
            SaveFile<Project>(ProjectsFile, ProjectSeparator);
        }

        /// <summary>
        /// Open certain file.
        /// </summary>
        /// <typeparam name="T">List type.</typeparam>
        /// <param name="filePath">File path.</param>
        /// <param name="separator">File separator.</param>
        private static void OpenFile<T>(string filePath, string separator)
        {
            try
            {
                var objectsFile = Path.Combine(ManagerPath, SettingsPath, filePath);

                if (!File.Exists(objectsFile))
                {
                    File.Create(objectsFile);
                    return;
                }

                // Read file.
                using var fileStream = new FileStream(objectsFile, FileMode.Open, FileAccess.Read);
                using var streamReader = new StreamReader(fileStream);

                var jsonObjects = streamReader.ReadToEnd().Split(separator);

                // Set up json option.
                var options = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All,
                    PreserveReferencesHandling = PreserveReferencesHandling.All
                };

                foreach (var jsonObject in jsonObjects)
                {
                    try
                    {
                        // Add deserialized object in certain list.
                        if (typeof(T) == typeof(User))
                        {
                            var newUser = JsonConvert.DeserializeObject<User>(jsonObject, options);
                            if (newUser != null)
                            {
                                Users.Add(newUser);
                            }
                        }

                        else if (typeof(T) == typeof(Project))
                        {
                            var newProject = JsonConvert.DeserializeObject<Project>(jsonObject, options);
                            if (newProject != null)
                            {
                                Projects.Add(newProject);
                            }
                        }
                    }
                    catch
                    {
                        // ignored
                    }
                }
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Application load method.
        /// </summary>
        private static void ApplicationLoad()
        {
            try
            {
                // Create hidden folder
                var managerDirectory = Directory.CreateDirectory(ManagerPath);
                managerDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                managerDirectory.CreateSubdirectory(SettingsPath);

                // Open data files.
                OpenFile<User>(UsersFile, UserSeparator);
                OpenFile<Project>(ProjectsFile, ProjectSeparator);
            }
            catch
            {
                // ignored
            }
        }
    }
}