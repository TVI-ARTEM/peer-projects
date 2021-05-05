using System;
using ProjectLibrary;
using static System.Console;


namespace TaskManagerConsole.Classes
{
    public static partial class Manager
    {
        /// <summary>
        /// Manage task method.
        /// </summary>
        private static void ManageTask()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(ManageTask);

            while (true)
            {
                try
                {
                    ManageTaskGui();

                    if (!uint.TryParse(ReadLine(), out var commandId))
                        throw new ArgumentException("Incorrect input.");

                    switch (CurrentTask.TypeTask)
                    {
                        case TypeTask.Epic:
                        case TypeTask.Project:
                            EpicProjectCommand((int) commandId);
                            return;
                        case TypeTask.Story:
                            StoryCommand((int) commandId);
                            return;
                        case TypeTask.Task:
                        case TypeTask.Bug:
                            TaskBugCommand((int) commandId);
                            return;
                    }
                }
                catch (Exception exception)
                {
                    if (PrintErrorMessage(exception)) return;
                }
            }
        }

        /// <summary>
        /// Manage task gui.
        /// </summary>
        private static void ManageTaskGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"This task: {CurrentTask}");
            ForegroundColor = ConsoleColor.Magenta;

            switch (CurrentTask.TypeTask)
            {
                case TypeTask.Epic:
                case TypeTask.Project:
                    EpicProjectCommandGui();
                    break;
                case TypeTask.Story:
                    StoryCommandGui();
                    break;
                case TypeTask.Task:
                case TypeTask.Bug:
                    TaskBugCommandGui();
                    break;
            }

            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            Write("Select command: ");
            ResetColor();
        }

        /// <summary>
        /// Change task state method.
        /// </summary>
        private static void ChangeState()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(ChangeState);

            while (true)
            {
                try
                {
                    ChangeStateGui();

                    if (!uint.TryParse(ReadLine(), out var stateId))
                        throw new ArgumentException("Incorrect input.");

                    switch (stateId)
                    {
                        case 1:
                            CurrentTask.ChangeState(State.Open);
                            break;
                        case 2:
                            CurrentTask.ChangeState(State.InProgress);
                            break;
                        case 3:
                            CurrentTask.ChangeState(State.Closed);
                            break;
                        default:
                            throw new ArgumentException("Incorrect input.");
                    }

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
        /// Change task state gui.
        /// </summary>
        private static void ChangeStateGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Yellow;

            WriteLine(CurrentTask);
            WriteLine();

            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("1. Open");
            WriteLine("2. In progress");
            WriteLine("3. Closed");
            WriteLine();
            ForegroundColor = ConsoleColor.Green;

            Write("Select state: ");
            ResetColor();
        }


        /// <summary>
        /// Change task name.
        /// </summary>
        private static void ChangeName()
        {
            // Add current method to list of previous methods.
            PreviousMethods.Add(ChangeName);

            while (true)
            {
                try
                {
                    ChangeNameGui();

                    CurrentTask.Name = ReadLine();

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
        /// Change task name gui.
        /// </summary>
        private static void ChangeNameGui()
        {
            Clear();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"Current name: {CurrentTask.Name}");
            WriteLine();
            ForegroundColor = ConsoleColor.Green;

            Write("Enter new name: ");
            ResetColor();

        }
    }
}