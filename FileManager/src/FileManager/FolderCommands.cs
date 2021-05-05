using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;

namespace Main
{
    public partial class FileManager
    {
        /// <summary>
        /// Create a folder in the current folder or by full path.
        /// </summary>
        public static void CreateNewFolder()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of folder (<Name folder>)\n" +
                      $"  or direct path to folder(<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Name folder>) ");

            // Path to folder.
            var folderPath = ReadLine();

            // Error processing.
            try
            {
                // Check folder exist.
                if (!Directory.Exists(folderPath))
                {
                    // Create folder.
                    Directory.CreateDirectory(folderPath);

                    // Help message for user.
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Folder created successfully!");
                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Folder already exists.");
                }
            }
            catch (IOException exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("Can't create a new folder in this folder." +
                          $"\nError: {exception.Message}");
            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine($"Error: {exception.Message}");
            }

            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Delete a folder in the current folder or by full path.
        /// </summary>
        public static void DeleteFolder()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of folder (<Name folder>)\n" +
                      $"  or direct path to folder(<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Name folder>) ");

            // Path to folder.
            var folderPath = ReadLine();

            // Error processing.
            try
            {
                // Check folder exist.
                if (Directory.Exists(folderPath))
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Are you sure you want to delete. Enter <yes> or <no>");

                    var userChoose = ReadLine()?.ToLower();

                    while (userChoose != "no" && userChoose != "yes")
                    {
                        WriteLine("Incorrect input...");
                        WriteLine("Are you sure you want to delete. Enter <yes> or <no>");

                        userChoose = ReadLine()?.ToLower();
                    }

                    if (userChoose == "yes")
                    {
                        // Delete a folder.
                        Directory.Delete(folderPath, true);
                        
                        // Help message for user.
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("Folder deleted successfully!");
                    }
                    else if (userChoose == "no")
                    {
                        // Help message for user.
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("The folder has not been deleted");
                    }
                }
                else
                {
                    // Help error message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Folder not found.");
                }
            }
            catch (IOException exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("Can't delete a folder in this folder." +
                          $"\nError: {exception.Message}");
            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine($"Error: {exception.Message}");
            }


            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Move folder to another directory.
        /// </summary>
        public static void MoveFolder()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of folders:\n" +
                      "    (<Source folder>\n" +
                      "    <Destination folder>)\n" +
                      "or direct path to folders:\n" +
                      $"   (<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Source folder>\n" +
                      $"    <Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Destination folder>) ");

            var sourceDirectoryPath = ReadLine();
            var destinationDirectoryPath = ReadLine();
            
            // Error processing.
            try
            {
                // Check folder exists.
                if (Directory.Exists(sourceDirectoryPath))
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Are you sure you want to move. Enter <yes> or <no>");

                    var userChoose = ReadLine()?.ToLower();

                    while (userChoose != "no" && userChoose != "yes")
                    {
                        WriteLine("Incorrect input...");
                        WriteLine("Are you sure you want to move. Enter <yes> or <no>");

                        userChoose = ReadLine()?.ToLower();
                    }

                    if (userChoose == "yes")
                    {

                        Directory.Move(sourceDirectoryPath, destinationDirectoryPath);
                        
                        // Help message for user.
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("Folder moved successfully!");
                    }
                    else if (userChoose == "no")
                    {
                        // Help message for user.
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("The folder has not been moved");
                    }
                }
                else
                {
                    // Help error message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Folder not found.");
                }
            }
            catch (IOException exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("Can't move a folder in this folder." +
                          $"\nError: {exception.Message}");
            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine($"Error: {exception.Message}");
            }


            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Copying a folder to another directory, without the ability to overwrite folders and files
        /// </summary>
        public static void CopyFolder()
        {
            // Help messages for user.
            WriteLine();
            WriteLine("Enter name of folders:\n" +
                      "    (<Source folder>\n" +
                      "    <Destination folder>)\n" +
                      "or direct path to folders:\n" +
                      $"   (<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Source folder>\n" +
                      $"    <Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Destination folder>) ");
            
            ForegroundColor = ConsoleColor.Red;
            WriteLine();
            WriteLine("Without overwrite");
            WriteLine();

            ForegroundColor = ConsoleColor.White;
            var sourceDirectoryPath = ReadLine();
            var destinationDirectoryPath = ReadLine();

            // Help method for copy.
            var result = CopyFolderInternal(sourceDirectoryPath, destinationDirectoryPath);

            WriteLine();

            if (result)
            {
                // Help message for user.
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Folder copied successfully!");
            }
            else
            {
                // Help message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Folder didn't copy!");
            }

            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Help method for copy a folder.
        /// </summary>
        /// <param name="sourceDirectoryPath">Source path folder</param>
        /// <param name="destinationDirectoryPath">Destination path folder</param>
        /// <returns>Return result of copy operation</returns>
        public static bool CopyFolderInternal(string sourceDirectoryPath, string destinationDirectoryPath)
        {
            // Error processing.
            try
            {
                // Check folder exists.
                if (Directory.Exists(sourceDirectoryPath))
                {
                    var dir = new DirectoryInfo(sourceDirectoryPath);

                    var directories = dir.GetDirectories();

                    Directory.CreateDirectory(destinationDirectoryPath);

                    var files = dir.GetFiles();

                    // Copy files to destination directory.
                    foreach (var file in files)
                    {
                        var tempPath = Path.Combine(destinationDirectoryPath, file.Name);

                        file.CopyTo(tempPath, false);
                    }

                    // Recursive method execution.
                    foreach (var subDir in directories)
                    {
                        var tempPath = Path.Combine(destinationDirectoryPath, subDir.Name);

                        CopyFolderInternal(subDir.FullName, tempPath);
                    }

                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Source Folder not found.");

                    return false;
                }
            }
            catch (IOException exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\nCan not copy or find source folder.");
                WriteLine($"Error: {exception.Message}");

                return false;
            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"\nError: {exception.Message}");

                return false;
            }

            return true;
        }


        /// <summary>
        /// Get folder contents of the current path.
        /// </summary>
        public static void GetCurrentFolderContent()
        {
            // Error processing.
            try
            {
                var directories = Directory.GetDirectories(InitializeCurrentPath());
                var files = Directory.GetFiles(InitializeCurrentPath());

                // Help message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("It can take some time...");
                WriteLine();

                // Write name of titles.
                ForegroundColor = ConsoleColor.White;
                WriteLine();
                WriteLine(new StringBuilder().Insert(0, " =", 47).ToString());
                WriteLine(
                    $"||{"Name".PadLeft(20),-40}" +
                    $"|{"Last write time".PadLeft(18),-20}" +
                    $"|{"Type".PadLeft(10),-16}" +
                    $"|{"Size (byte)".PadLeft(12),-13}||"
                );
                WriteLine(new StringBuilder().Insert(0, " =", 47).ToString());

                // Get folder info.
                foreach (var directory in directories)
                {
                    var directoryInfo = new DirectoryInfo(directory);

                    try
                    {
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine($"||{directoryInfo.Name.PadLeft(30),-40}" +
                                  $"|{directoryInfo.LastWriteTime.ToString(CultureInfo.CurrentCulture).PadLeft(17),-19}" +
                                  $"|{"Folder".PadLeft(10),-16}" +
                                  $"|{GetSizeOfFolder(directoryInfo).ToString().PadLeft(12),-13}||");
                    }
                    catch (Exception)
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine($"||{directoryInfo.Name.PadLeft(30),-40}" +
                                  $"|{"Is denied".PadLeft(14),-20}" +
                                  $"|{"Is denied".PadLeft(12),-16}" +
                                  $"|{"Is denied".PadLeft(12),-13}||");
                    }
                }

                // Get file info.
                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);
                    try
                    {
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine($"||{fileInfo.Name.PadLeft(30),-40}" +
                                  $"|{fileInfo.LastWriteTime.ToString(CultureInfo.CurrentCulture).PadLeft(17),-19}" +
                                  $"|{fileInfo.Extension.PadLeft(10),-16}" +
                                  $"|{fileInfo.Length.ToString().PadLeft(12),-13}||");
                    }
                    catch (Exception)
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine($"||{fileInfo.Name.PadLeft(30),-40}" +
                                  $"|{"Is denied".PadLeft(14),-20}" +
                                  $"|{"Is denied".PadLeft(12),-16}" +
                                  $"|{"Is denied".PadLeft(12),-13}||");
                    }
                }
            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"\n{InitializeCurrentPath()} is denied.\nError: {exception.Message}");
            }

            ForegroundColor = ConsoleColor.White;
            WriteLine(new StringBuilder().Insert(0, " =", 47).ToString());


            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Get folder info: name, attributes, size and etc.
        /// </summary>
        public static void GetFolderInfo()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of folder (<Name folder>)\n" +
                      $"  or direct path to folder(<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Name folder>)\n" +
                      "  or </.> to show info of current folder:");

            var directoryPath = ReadLine();
            
            // Error processing.
            try
            {
                directoryPath = string.Equals(directoryPath, "/.", StringComparison.InvariantCultureIgnoreCase)
                    ? InitializeCurrentPath()
                    : directoryPath;
                // Check folder exists.
                if (Directory.Exists(directoryPath))
                {
                    var directoryInfo = new DirectoryInfo(directoryPath);
                    
                    // Write folder info.
                    WriteLine($"{"Name: ",8}{directoryInfo.Name}");
                    WriteLine($"{"Attributes: ",14}{directoryInfo.Attributes}");
                    WriteLine($"{"Creation time: ",17}{directoryInfo.CreationTime}");
                    WriteLine($"{"Last access time: ",20}{directoryInfo.LastAccessTime}");
                    WriteLine($"{"Last write time: ",19}{directoryInfo.LastWriteTime}");
                    WriteLine($"{"Size: ",8}{GetSizeOfFolder(directoryInfo)} bytes");
                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Folder not found.");
                }
            }
            catch (IOException exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\nCan not find folder info.");
                WriteLine($"Error: {exception.Message}");
            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"\nError: {exception.Message}");
            }


            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Help method for calculating a size of folder
        /// </summary>
        /// <param name="directoryInfo">Info of directory</param>
        /// <returns>Returns size of folder in bytes.</returns>
        public static long GetSizeOfFolder(DirectoryInfo directoryInfo)
        {
            var directories = directoryInfo.GetDirectories();
            var files = directoryInfo.GetFiles();

            // Recursively calculating the size of files in the current folder and its children.
            return files.Sum(file => file.Length) + directories.Sum(directory => GetSizeOfFolder(directory));
        }


        /// <summary>
        /// Find file or folder by pattern
        /// </summary>
        public static void SearchFileOrFolder()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of folder\n" +
                      "  (<Name folder>)\n" +
                      $"  or direct path to folder(<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Name folder>)\n" +
                      "  or </.> to show info of current folder\n" +
                      "and search pattern of file\n" +
                      "  (<search pattern>):\n");

            var directoryPath = ReadLine();
            var searchPattern = ReadLine()?.ToLower();
            
            // Error processing.
            try
            {
                directoryPath = string.Equals(directoryPath, "/.", StringComparison.InvariantCultureIgnoreCase)
                    ? InitializeCurrentPath()
                    : directoryPath;
                // Check folder exists.
                if (Directory.Exists(directoryPath))
                {
                    var directoryInfo = new DirectoryInfo(directoryPath);

                    var searchResult = SearchInternal(directoryInfo, searchPattern);
                    
                    // Write name of titles.
                    WriteLine();
                    WriteLine(new StringBuilder().Insert(0, " =", 41).ToString());
                    WriteLine(
                        $"||{"Name".PadLeft(20),-40}" +
                        $"|{"Last write time".PadLeft(19),-22}" +
                        $"|{"Type".PadLeft(10),-16}||"
                    );
                    WriteLine(new StringBuilder().Insert(0, " =", 41).ToString());

                    // Write info of result.
                    foreach (var fileSystemInfo in searchResult)
                    {
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine($"||{fileSystemInfo.Name.PadLeft(30),-40}" +
                                  $"|{fileSystemInfo.LastWriteTime.ToString(CultureInfo.CurrentCulture).PadLeft(21),-22}" +
                                  $"|{(string.IsNullOrEmpty(fileSystemInfo.Extension) ? "Folder" : fileSystemInfo.Extension).PadLeft(10),-16}||");
                    }
                }
                else
                {
                    // Help message for user. 
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Folder or file not found.");
                }
            }
            catch (IOException exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\nCan not find folder or file info.");
                WriteLine($"Error: {exception.Message}");
            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"\nError: {exception.Message}");
            }

            WriteLine(new StringBuilder().Insert(0, " =", 41).ToString());


            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Help method for search file and folder by pattern.
        /// </summary>
        /// <param name="directory">Info of folder.</param>
        /// <param name="searchPattern">User search pattern.</param>
        /// <returns>Returns list of result(name of folders and files)</returns>
        public static List<FileSystemInfo> SearchInternal(DirectoryInfo directory, string searchPattern)
        {
            var res = new List<FileSystemInfo>();

            var directories = directory.GetDirectories();
            var files = directory.GetFiles();

            foreach (var directoryInfo in directories)
            {
                // Error processing.
                try
                {
                    // Check folder for search pattern
                    if (directoryInfo.Name.ToLower().Contains(searchPattern))
                    {
                        res.Add(directoryInfo);
                    }

                    res.AddRange(SearchInternal(directoryInfo, searchPattern));
                }
                catch (Exception)
                {
                    continue;
                }
            }

            foreach (var fileInfo in files)
            {
                // Error processing.
                try
                {
                    // Check file for search pattern
                    if (fileInfo.Name.ToLower().Contains(searchPattern))
                    {
                        res.Add(fileInfo);
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }

            return res;
        }


        /// <summary>
        /// Changing the current path to the one entered by the user.
        /// </summary>
        public static void GoToFolder()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of folder (<Name folder>)\n" +
                      $"  or direct path to folder(<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Name folder>)\n");

            var path = ReadLine();

            // Error processing.
            try
            {
                // Check folder exists.
                if (Directory.Exists(path))
                {
                    // Clear current path.
                    CurrentPath.Clear();
                    // Change current path to new path.
                    var directoryInfo = new DirectoryInfo(path);
                    CurrentPath = InitializeCurrentPath(directoryInfo.FullName);

                    // Help message for user.
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine($"Current path successfully changed to: {InitializeCurrentPath()}");
                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Incorrect path.");
                }
            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Folder not found or is denied");
                WriteLine($"Error: {exception.Message}");
            }


            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Change current path to one directory level up.
        /// </summary>
        public static void UpToFolder()
        {
            // Error processing.
            try
            {
                var directoryInfo = new DirectoryInfo(InitializeCurrentPath());

                // Check folder's parent folder exists.
                if (directoryInfo.Parent != null)
                {
                    // Clear current path.
                    CurrentPath.Clear();

                    // Change current path.
                    CurrentPath.Add(directoryInfo.Parent.ToString());

                    ForegroundColor = ConsoleColor.Green;
                    WriteLine($"Current path successfully changed to: {InitializeCurrentPath()}");
                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("This folder does not have a root folder");
                }
            }

            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"\nError: {exception.Message}");
            }


            WaitAnyKey();

            MainMenu();
        }


        /// <summary>
        /// Get info of drives.
        /// </summary>
        public static void GetDriveInfo()
        {
            // Write name of titles.
            WriteLine();
            WriteLine(new StringBuilder().Insert(0, " =", 50).ToString());
            WriteLine(
                $"||{"№".PadLeft(2),-3}" +
                $"|{"Name".PadLeft(5),-6}" +
                $"|{"File type".PadLeft(10),-11}" +
                $"|{"Volume Label".PadLeft(13),-14}" +
                $"|{"File System".PadLeft(12),-13}" +
                $"|{"Total available space".PadLeft(22),-23}" +
                $"|{"Total size of drive".PadLeft(21),-22}||"
            );
            WriteLine(new StringBuilder().Insert(0, " =", 50).ToString());


            var index = 1;
            
            // Write info of drive.
            foreach (var drive in Drives)
            {
                // Check drive for ready to use.
                if (drive.IsReady)
                {
                    var totalFreeSpace = drive.TotalFreeSpace * 1.0 / Math.Pow(2, 30);
                    var totalSize = drive.TotalSize * 1.0 / Math.Pow(2, 30);

                    WriteLine(
                        $"||{index++.ToString().PadLeft(2),-3}" +
                        $"|{drive.Name.PadLeft(5),-6}" +
                        $"|{drive.DriveType.ToString().PadLeft(8),-11}" +
                        $"|{drive.VolumeLabel.PadLeft(12),-14}" +
                        $"|{drive.DriveFormat.PadLeft(8),-13}" +
                        $"|{$"{totalFreeSpace:0.00}GB".PadLeft(15),-23}" +
                        $"|{$"{totalSize:0.00}GB".PadLeft(15),-22}||");
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine(
                        $"||{index++.ToString().PadLeft(2),-3}" +
                        $"|{drive.Name.PadLeft(5),-6}" +
                        $"|{drive.DriveType.ToString().PadLeft(8),-11}" +
                        $"|{"Not Ready".PadLeft(12),-14}" +
                        $"|{"Not Ready".PadLeft(11),-13}" +
                        $"|{"Not Ready".PadLeft(15),-23}" +
                        $"|{"Not Ready".PadLeft(15),-22}||"
                    );
                    ForegroundColor = ConsoleColor.White;
                }
            }

            WriteLine(new StringBuilder().Insert(0, " =", 50).ToString());


            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Change current path to the root folder of the drive.
        /// </summary>
        public static void SelectDrive()
        {
            // Write name of titles.
            WriteLine();
            WriteLine(new StringBuilder().Insert(0, " =", 16).ToString());
            WriteLine(
                $"||{"№".PadLeft(2),-3}" +
                $"|{"Name".PadLeft(5),-6}" +
                $"|{"File type".PadLeft(10),-11}" +
                $"|{"Ready".PadLeft(6),-6}||"
            );
            WriteLine(new StringBuilder().Insert(0, " =", 16).ToString());


            var index = 1;

            // Write info of drives.
            foreach (var drive in Drives)
            {
                WriteLine(
                    $"||{index++.ToString().PadLeft(2),-3}" +
                    $"|{drive.Name.PadLeft(5),-6}" +
                    $"|{drive.DriveType.ToString().PadLeft(8),-11}" +
                    $"|{drive.IsReady,-6}||"
                );
            }

            WriteLine(new StringBuilder().Insert(0, " =", 16).ToString());

            // Help message for user.
            WriteLine();
            Write("Select drive(enter name of drive example: \'C\'-->\"C:\\\" ): ");

            var userDrive = ReadLine()?.ToUpper() + ":";

            // Check user choice for valid.
            if (IsDriveValid(userDrive))
            {
                // Change current path.
                CurrentPath.Clear();
                CurrentPath.Add(userDrive);

                // Help message for user.
                ForegroundColor = ConsoleColor.Green;
                WriteLine($"Current path successfully changed to: {InitializeCurrentPath()}");
            }
            else
            {
                // Help message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Drive not found or not ready to use.");
            }


            WaitAnyKey();

            MainMenu();
        }
    }
}