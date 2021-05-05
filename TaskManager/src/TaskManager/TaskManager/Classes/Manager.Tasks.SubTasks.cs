using System;
using ProjectLibrary;
using static System.Console;

namespace TaskManagerConsole.Classes
{
    public static partial class Manager
    {
        /// <summary>
        /// Manage subTasks of task. 
        /// </summary>
        private static void ManageSubTask()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(ManageSubTask);
            while (true)
            {
                try
                {
                    ManageSubTaskGui();

                    if (!uint.TryParse(ReadLine(), out var taskId))
                        throw new ArgumentException("Incorrect input.");

                    if (taskId == (CurrentTask as IManageable)?.Tasks.Count + 1)
                    {
                        ReturnBack();
                        return;
                    }

                    CurrentTask = CurrentTask.GetTask((int) taskId - 1);
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
        /// Change manage subTasks of task gui.
        /// </summary>
        private static void ManageSubTaskGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            if ((CurrentTask as IManageable)?.Tasks.Count == 0)
            {
                throw new Exception("There are no sub tasks.");
            }

            PrintArray((CurrentTask as IManageable)?.Tasks);
            WriteLine($"{(CurrentTask as IManageable)?.Tasks.Count + 1}. Back");
            WriteLine();
            ForegroundColor = ConsoleColor.Green;

            Write("Select id: ");
            ResetColor();
        }

        /// <summary>
        /// Commands for epic and project.
        /// </summary>
        /// <param name="commandId">Command id.</param>
        private static void EpicProjectCommand(int commandId)
        {
            switch (commandId)
            {
                case 1:
                    ManageSubTask();
                    break;
                case 2:
                    CreateSubTask();
                    break;
                case 3:
                    RemoveSubTask();
                    break;
                case 4:
                    ChangeState();
                    break;
                case 5:
                    ChangeName();
                    break;
                case 6:
                    CurrentTask = CurrentTask.Owner;
                    break;
                default:
                    throw new ArgumentException("Incorrect input");
            }

            ReturnBack();
        }

        /// <summary>
        /// Commands for epic and project gui.
        /// </summary>
        private static void EpicProjectCommandGui()
        {
            WriteLine("1. Manage sub tasks");
            WriteLine("2. Create new sub tasks");
            WriteLine("3. Remove sub tasks");
            WriteLine("4. Change state");
            WriteLine("5. Change name");
            WriteLine("6. Back");
        }

        /// <summary>
        /// Commands for task and bug.
        /// </summary>
        /// <param name="commandId">Command id.</param>
        private static void TaskBugCommand(int commandId)
        {
            switch (commandId)
            {
                case 1:
                    ShowTaskUser();
                    break;
                case 2:
                    AddUser();
                    break;
                case 3:
                    RemoveUser();
                    break;
                case 4:
                    ChangeState();
                    break;
                case 5:
                    ChangeName();
                    break;
                case 6:
                    CurrentTask = CurrentTask.Owner;
                    break;
                default:
                    throw new ArgumentException("Incorrect input");
            }

            ReturnBack();
        }

        /// <summary>
        /// Commands for task and bug gui.
        /// </summary>
        private static void TaskBugCommandGui()
        {
            WriteLine("1. Show users");
            WriteLine("2. Add new user");
            WriteLine("3. Remove user");
            WriteLine("4. Change state");
            WriteLine("5. Change name");
            WriteLine("6. Back");
        }

        /// <summary>
        /// Commands for story.
        /// </summary>
        /// <param name="commandId">Command id.</param>
        private static void StoryCommand(int commandId)
        {
            switch (commandId)
            {
                case 1:
                    ManageSubTask();
                    break;
                case 2:
                    CreateSubTask();
                    break;
                case 3:
                    RemoveSubTask();
                    break;
                case 4:
                    ShowTaskUser();
                    break;                
                case 5:
                    AddUser();
                    break;
                case 6:
                    RemoveUser();
                    break;
                case 7:
                    ChangeState();
                    break;
                case 8:
                    ChangeName();
                    break;
                case 9:
                    CurrentTask = CurrentTask.Owner;
                    break;
                default:
                    throw new ArgumentException("Incorrect input");
            }

            ReturnBack();
        }

        /// <summary>
        /// Commands for story.
        /// </summary>
        private static void StoryCommandGui()
        {
            WriteLine("1. Manage sub tasks");
            WriteLine("2. Create new sub tasks");
            WriteLine("3. Remove sub tasks");
            WriteLine("4. Show users");
            WriteLine("5. Add new user");
            WriteLine("6. Remove user");
            WriteLine("7. Change state");
            WriteLine("8. Change name");
            WriteLine("9. Back");
        }

        /// <summary>
        /// Create new subTask in current task. 
        /// </summary>
        private static void CreateSubTask()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(CreateSubTask);

            while (true)
            {
                try
                {
                    CreateSubTaskGui();

                    if (!uint.TryParse(ReadLine(), out var typeId))
                        throw new ArgumentException("Incorrect input.");
                    BaseTask baseTask;
                    switch (typeId)
                    {
                        case 1:
                            baseTask = new Epic("new task");
                            break;
                        case 2:
                            baseTask = new Story("new task");
                            break;
                        case 3:
                            baseTask = new Task("new task");
                            break;
                        case 4:
                            baseTask = new Bug("new task");
                            break;
                        case 5:
                            ReturnBack();
                            return;
                        default:
                            throw new ArgumentException("Incorrect input");
                    }

                    CreateSubTaskGui(2);
                    baseTask.Name = ReadLine();

                    if (baseTask is IManageable )
                    {
                        CreateSubTaskGui(3);

                        if (!uint.TryParse(ReadLine(), out var maxTasks))
                            throw new ArgumentException("Incorrect input.");

                        ((IManageable)baseTask).MaxTasks = maxTasks;
                    }

                    (CurrentTask as IManageable)?.AddTask(baseTask);

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
        /// Create new subTask for current task gui.
        /// </summary>
        /// <param name="option">Option - what need to show.</param>
        private static void CreateSubTaskGui(int option = 1)
        {
            Clear();
            ForegroundColor = ConsoleColor.Magenta;
            switch (option)
            {
                case 1:
                    WriteLine("Choose type of new task.");
                    WriteLine("1. Epic");
                    WriteLine("2. Story");
                    WriteLine("3. Task");
                    WriteLine("4. Bug");
                    WriteLine("5. Back");

                    WriteLine();
                    ForegroundColor = ConsoleColor.Green;

                    Write("Select id: ");
                    break;

                case 2:
                    WriteLine("Enter name of a new task");
                    ForegroundColor = ConsoleColor.Green;

                    Write("Name: ");
                    break;
                case 3:
                    WriteLine("Enter a value of max tasks of the task");
                    ForegroundColor = ConsoleColor.Green;

                    Write("Max tasks: ");
                    break;
            }

            ResetColor();
        }


        /// <summary>
        /// Remove subTask from current task.
        /// </summary>
        private static void RemoveSubTask()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(RemoveSubTask);

            while (true)
            {
                try
                {
                    RemoveSubTaskGui();

                    if (!uint.TryParse(ReadLine(), out var taskId))
                        throw new ArgumentException("Incorrect input.");

                    if (taskId == (CurrentTask as IManageable)?.Tasks.Count + 1)
                    {
                        ReturnBack();
                        return;
                    }

                    (CurrentTask as IManageable)?.RemoveTask(CurrentTask.GetTask((int) taskId - 1));

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
        /// Remove subTask from current task gui.
        /// </summary>
        private static void RemoveSubTaskGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            if ((CurrentTask as IManageable)?.Tasks.Count == 0)
            {
                throw new Exception("There are no sub tasks.");
            }

            PrintArray((CurrentTask as IManageable)?.Tasks);
            WriteLine($"{(CurrentTask as IManageable)?.Tasks.Count + 1}. Back");
            WriteLine();
            ForegroundColor = ConsoleColor.Green;

            Write("Select id: ");
            ResetColor();
        }
    }
}