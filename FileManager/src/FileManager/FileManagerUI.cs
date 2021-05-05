using System;
using System.IO;
using System.Text;
using static System.Console;

namespace Main
{
    public partial class FileManager
    {
        /// <summary>
        /// Main Menu
        /// </summary>
        public static void MainMenu()
        {
            Clear();
            
            // Change current path.
            Environment.CurrentDirectory = InitializeCurrentPath();
            
            // Get info of drives.
            Drives = DriveInfo.GetDrives();

            // Help messages for user.
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine($"Current path: {InitializeCurrentPath()}");
            
            ForegroundColor = ConsoleColor.White;
            WriteLine("To view the commands, enter 'help'.");

            ForegroundColor = ConsoleColor.Green;
            Write("Enter the command: ");

            ForegroundColor = ConsoleColor.White;

            WaitUserCommand();
        }

        /// <summary>
        /// Check user command by valid and start command.
        /// </summary>
        public static void WaitUserCommand()
        {
            while (true)
            {
                var userCommand = ReadLine()?.ToLower();
                
                // Check user command.
                switch (userCommand)
                {
                    case "help":
                        HelpInfo();
                        break;

                    case "select_drive":
                        SelectDrive();
                        break;

                    case "drive_info":
                        GetDriveInfo();
                        break;

                    case "folder_info":
                        GetFolderInfo();
                        break;

                    case "folder_content":
                        GetCurrentFolderContent();
                        break;

                    case "create_folder":
                        CreateNewFolder();
                        break;

                    case "copy_folder":
                        CopyFolder();
                        break;

                    case "move_folder":
                        MoveFolder();
                        break;

                    case "delete_folder":
                        DeleteFolder();
                        break;

                    case "go_to":
                        GoToFolder();
                        break;

                    case "search":
                        SearchFileOrFolder();
                        break;

                    case "file_info":
                        GetFileInfo();
                        break;

                    case "create_file":
                        CreateNewFile();
                        break;

                    case "delete_file":
                        DeleteFile();
                        break;

                    case "copy_file":
                        CopyFile();
                        break;

                    case "move_file":
                        MoveFile();
                        break;

                    case "up":
                        UpToFolder();
                        break;

                    case "read_files":
                        ReadFiles();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        IncorrectCommand();
                        break;
                }

                break;
            }
        }

        /// <summary>
        /// Shows info of existing commands.
        /// </summary>
        public static void HelpInfo()
        {
            Clear();

            WriteLine(new StringBuilder().Insert(0, " =", 42).ToString());
            WriteLine($"||{"Command".PadLeft(10),-14}|{"Task being performed".PadLeft(35),-66}||");
            WriteLine(new StringBuilder().Insert(0, " =", 42).ToString());

            WriteLine($"||{"go_to",-14}|{"Change current path",-66}||");
            WriteLine($"||{"up",-14}|{"To navigate up one directory level",-66}||");

            WriteLine($"||{"search",-14}|{"Search file or folder by pattern in destination folder",-66}||");

            WriteLine($"||{"drive_info", -14}|{"Get drive info",-66}||");
            WriteLine($"||{"select_drive",-14}|Change current path to <Name drive:{Path.DirectorySeparatorChar}{">",-30}||");
            WriteLine($"||{"folder_info",-14}|{"Get folder info",-66}||");
            WriteLine($"||{"folder_content",-14}|{"Get folder content",-66}||");
            WriteLine($"||{"create_folder",-14}|{"Create a new folder in destination folder",-66}||");
            WriteLine($"||{"delete_folder",-14}|{"Delete a folder",-66}||");
            WriteLine($"||{"copy_folder",-14}|{"Copy a source folder to a destination folder",-66}||");
            WriteLine($"||{"move_folder",-14}|{"Move a source folder to a destination folder",-66}||");

            WriteLine($"||{"file_info",-14}|{"Get file info",-66}||");
            WriteLine($"||{"create_file",-14}|{"Create a new file in destination folder",-66}||");
            WriteLine($"||{"delete_file",-14}|{"Delete a file", -66}||");
            WriteLine($"||{"copy_file",-14}|{"Copy a source file to a destination folder",-66}||");
            WriteLine($"||{"move_file",-14}|{"Move a source file to a destination folder", -66}||");
            WriteLine($"||{"read_files",-14}|{"Output contents of one or more files to console and save in file.", -66}||");

            WriteLine($"||{"help",-14}|{"Help info",-66}||");
            WriteLine($"||{"exit",-14}|{"Close the program",-66}||");

            WriteLine(new StringBuilder().Insert(0, " =", 42).ToString());

            WaitAnyKey();

            MainMenu();
        }


        /// <summary>
        /// Help method shows "Incorrect input..."
        /// </summary>
        private static void IncorrectCommand()
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("Incorrect input...");

            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Help method waiting user action.
        /// </summary>
        private static void WaitAnyKey()
        {
            WriteLine();
            
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter any key...");
            
            ReadKey();
        }
    }
}