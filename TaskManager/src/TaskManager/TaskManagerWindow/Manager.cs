using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectLibrary;

namespace TaskManagerWindow
{
    public static class Manager
    {
        public const string ManagerPath = "TaskManager";
        public const string SettingsPath = "Settings";
        public const string ProjectsFile = "Projects.txt";
        public const string UsersFile = "Users.txt";
        public const string ProjectSeparator = "**=EndProject=**";
        public const string UserSeparator = "**=EndUser=**";

        /// <summary>
        /// List of current user.
        /// </summary>
        public static List<User> Users { get; set; }

        /// <summary>
        /// List of current projects.
        /// </summary>
        public static List<Project> Projects { get; set; }

        /// <summary>
        /// Current task).
        /// </summary>
        public static BaseTask CurrentTask;


        /// <summary>
        /// Sort tasks by task's state.
        /// </summary>
        public static void SortTasks()
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
        /// Save certain data list to file.
        /// </summary>
        /// <typeparam name="T">List type.</typeparam>
        /// <param name="filePath">File path.</param>
        /// <param name="separator">File separator.</param>
        public static void SaveFile<T>(string filePath, string separator)
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
        public static void SaveData()
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
        public static void OpenFile<T>(string filePath, string separator)
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
        public static void ApplicationLoad()
        {
            try
            {
                // Create hidden folder
                var managerDirectory = Directory.CreateDirectory(ManagerPath);
                managerDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                managerDirectory.CreateSubdirectory(SettingsPath);
                Users = new List<User>();
                Projects = new List<Project>(); 
                
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