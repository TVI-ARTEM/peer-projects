using System;
using ProjectLibrary;
using static System.Console;

namespace TaskManagerConsole.Classes
{
    public static partial class Manager
    {
        /// <summary>
        /// Manage projects method.
        /// </summary>
        private static void ManageProjects()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(ManageProjects);

            while (true)
            {
                try
                {
                    ManageProjectsGui();

                    if (!uint.TryParse(ReadLine(), out var command))
                        throw new ArgumentException("Incorrect input.");

                    switch (command)
                    {
                        case 1:
                            ManageProject();
                            return;
                        case 2:
                            CreateNewProject();
                            return;
                        case 3:
                            RemoveProject();
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
        }

        /// <summary>
        /// Manage projects gui method.
        /// </summary>
        private static void ManageProjectsGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("1. Manage project");
            WriteLine("2. Create new project");
            WriteLine("3. Remove project");
            WriteLine("4. Back");

            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            Write("Select command: ");
            ResetColor();
        }

        /// <summary>
        /// Manage current project method.
        /// </summary>
        private static void ManageProject()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(ManageProject);

            while (true)
            {
                try
                {
                    ManageProjectGui();

                    if (!uint.TryParse(ReadLine(), out var projectId))
                        throw new ArgumentException("Incorrect input.");

                    if (projectId == Projects.Count + 1)
                    {
                        ReturnBack();
                        return;
                    }
                    // Choose project and go to manage task.
                    CurrentTask = Projects[(int) projectId - 1];

                    ManageTask();

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
        /// Manage projects gui method.
        /// </summary>
        private static void ManageProjectGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            if (Projects.Count == 0)
            {
                throw new Exception("There are no projects.");
            }

            PrintArray(Projects);
            WriteLine($"{Projects.Count + 1}. Back");
            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            Write("Select Id: ");
            ResetColor();
        }

        /// <summary>
        /// Create new project.
        /// </summary>
        private static void CreateNewProject()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(CreateNewProject);

            while (true)
            {
                try
                {
                    CreateNewProjectGui();
                    var newProject = new Project(ReadLine());

                    CreateNewProjectGui(2);
                    if (!uint.TryParse(ReadLine(), out var maxTasks))
                        throw new ArgumentException("Incorrect input.");

                    newProject.MaxTasks = maxTasks;

                    Projects.Add(newProject);

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
        /// Create new project gui.
        /// </summary>
        /// <param name="option">Option - what need to show.</param>
        private static void CreateNewProjectGui(int option = 1)
        {
            Clear();
            ForegroundColor = ConsoleColor.Magenta;

            switch (option)
            {
                case 1:
                    WriteLine("Enter a name of new project");
                    ForegroundColor = ConsoleColor.Green;

                    Write("Name: ");
                    break;
                case 2:
                    WriteLine("Enter a value of max tasks of the project");

                    ForegroundColor = ConsoleColor.Green;
                    Write("Max tasks: ");
                    break;
            }

            ResetColor();
        }

        /// <summary>
        /// Remove project.
        /// </summary>
        private static void RemoveProject()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(RemoveProject);

            while (true)
            {
                try
                {
                    RemoveProjectGui();

                    if (!uint.TryParse(ReadLine(), out var projectId))
                        throw new ArgumentException("Incorrect input.");

                    if (projectId == Projects.Count + 1)
                    {
                        ReturnBack();
                        return;
                    }

                    Projects.RemoveAt((int) (projectId - 1));

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
        /// Remove project gui.
        /// </summary>
        private static void RemoveProjectGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            if (Projects.Count == 0)
            {
                throw new Exception("There are no projects.");
            }

            PrintArray(Projects);
            WriteLine($"{Projects.Count + 1}. Back");
            WriteLine();

            ForegroundColor = ConsoleColor.Green;
            Write("Select Id: ");
            ResetColor();
        }
    }
}