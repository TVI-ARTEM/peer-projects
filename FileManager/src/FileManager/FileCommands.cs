using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;

namespace Main
{
    public partial class FileManager
    {
        /// <summary>
        /// Get info of file.
        /// </summary>
        public static void GetFileInfo()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of file (<Name file>)\n" +
                      $"  or direct path to file(<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Name file>)");

            var filePath = ReadLine();
            
            // Error processing.
            try
            {
                // Check file exists.
                if (File.Exists(filePath))
                {
                    var fileInfo = new FileInfo(filePath);

                    // Write info of file.
                    WriteLine($"{"Name: ",8}{fileInfo.Name}");
                    WriteLine($"{"Attributes: ",14}{fileInfo.Attributes}");
                    WriteLine($"{"Creation time: ",17}{fileInfo.CreationTime}");
                    WriteLine($"{"Last access time: ",20}{fileInfo.LastAccessTime}");
                    WriteLine($"{"Last write time: ",19}{fileInfo.LastWriteTime}");
                    WriteLine($"{"Size: ",8}{fileInfo.Length} bytes");
                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("File not found.");
                }
            }
            catch (IOException exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Can not get file info ");
                WriteLine($"Error: {exception.Message}");
            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {exception.Message}");
            }

            
            WaitAnyKey();

            MainMenu();
        }


        /// <summary>
        /// Create a new file in current folder or in direct path.
        /// </summary>
        public static void CreateNewFile()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of file (<Name file.txt>)\n" +
                      $"  or direct path to file(<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Name file.txt>)");

            var fileNamePath = ReadLine();
            // Error processing.
            try
            {
                // Check file exists.
                if (!File.Exists(fileNamePath))
                {
                    var filePath = fileNamePath.Split(Path.DirectorySeparatorChar);
                    var fileName = filePath[^1].Split(".");
                    var extensionFile = fileName[^1];

                    // Check file extension.
                    if (extensionFile == "txt")
                    {
                        WriteLine();
                        File.WriteAllLines(fileNamePath, WriteText(), SelectEncoding());
                        WriteLine();

                        // Help message for user.
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("File created successfully!");
                    }
                    else
                    {
                        // Help message for user.
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("File's extension is not \".txt\".");
                    }
                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("File already exists.");
                }
            }
            catch (IOException exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("Can't create a new file in this folder." +
                          $"\nError: {exception.Message}");
            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine($"\nError: {exception.Message}");
            }


            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Copy a source file to destination folder.
        /// </summary>
        public static void CopyFile()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of files:\n" +
                      "    (<Source file>\n" +
                      "    <Destination file>)\n" +
                      "or direct path to files:\n" +
                      $"   (<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Source file>\n" +
                      $"    <Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Destination file>) ");

            var source = ReadLine();
            var destination = ReadLine();

            // Error processing.
            try
            {
                // Check file exists.
                if (File.Exists(source))
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Are you sure you want to copy. Enter <yes> or <no>");

                    var userChoose = ReadLine().ToLower();
                    
                    while (userChoose != "no" && userChoose != "yes")
                    {
                        WriteLine("Incorrect input...");
                        WriteLine("Are you sure you want to copy");
                    
                        userChoose = ReadLine().ToLower();
                    }

                    if (userChoose == "yes")
                    {
                        // Check for equals a source file name and path with a copied file name and path
                        if (Equals(source,destination))
                        {
                            // Help message for user.
                            WriteLine("Are you sure you want to overwrite. Enter <yes> or <no>");
                        
                            userChoose = ReadLine().ToLower();
                            
                            while (userChoose != "no" && userChoose != "yes")
                            {
                                WriteLine("Incorrect input...");
                                WriteLine("Are you sure you want to copy");
                                userChoose = ReadLine().ToLower();
                            }

                            if (userChoose=="yes")
                            {
                                // Copy a source file to destination folder with overwrite.
                                File.Copy(source, destination, true);
                            
                                ForegroundColor = ConsoleColor.Green;
                                WriteLine("File copied successfully!");
                            }
                            else if (userChoose == "no")
                            {
                                // Help message for user.
                                ForegroundColor = ConsoleColor.Red;
                                WriteLine("The file has not been copied");
                            }
                        }
                        else
                        {
                            // Copy a source file to destination folder.
                            File.Copy(source, destination);
                            
                            // Help message for user.
                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("File copied successfully!");
                        }
                        
                    }
                    else if (userChoose == "no")
                    {
                        // Help message for user.
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("The file has not been copied");
                    }
                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("File not found.");
                }
            }
            catch (IOException exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("Can't copy a file in this folder." +
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
        /// Move a source file to destination folder. 
        /// </summary>
        public static void MoveFile()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of files:\n" +
                      "    (<Source file>\n" +
                      "    <Destination file>)\n" +
                      "or direct path to files:\n" +
                      $"   (<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Source file>\n" +
                      $"    <Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Destination file>) ");

            var source = ReadLine();
            var destination = ReadLine();

            // Error processing.
            try
            {
                // Check file exists.
                if (File.Exists(source))
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Are you sure you want to move. Enter <yes> or <no>");

                    var userChoose = ReadLine().ToLower();

                    while (userChoose != "no" && userChoose != "yes")
                    {
                        WriteLine("Incorrect input...");
                        WriteLine("Are you sure you want to move");

                        userChoose = ReadLine().ToLower();
                    }

                    if (userChoose == "yes")
                    {
                        // Check equals of source name and path with destination name and path.
                        if (Equals(source, destination))
                        {
                            // Help message for user.
                            WriteLine("Are you sure you want to overwrite. Enter <yes> or <no>");

                            userChoose = ReadLine().ToLower();

                            while (userChoose != "no" && userChoose != "yes")
                            {
                                WriteLine("Incorrect input...");
                                WriteLine("Are you sure you want to move");
                                userChoose = ReadLine().ToLower();
                            }

                            if (userChoose == "yes")
                            {
                                // Move a source file to destination folder with overwrite.
                                File.Move(source, destination, true);

                                // Help message for user.
                                ForegroundColor = ConsoleColor.Green;
                                WriteLine("File moved successfully!");
                            }
                            else if (userChoose == "no")
                            {
                                // Help message for user.
                                ForegroundColor = ConsoleColor.Red;
                                WriteLine("The file has not been moved");
                            }
                        }
                        else
                        {
                            // Move a source file to destination folder.
                            File.Move(source, destination);

                            // Help message for user.
                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("File moved successfully!");
                        }

                    }
                    else if (userChoose == "no")
                    {
                        // Help message for user.
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("The file has not been copied");
                    }
                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("File not found.");
                }
            }
            catch (IOException exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("Can't move a file in this folder." +
                          $"\nError: {exception.Message}");
            }
            catch (Exception exception)
            {
                // Help message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine($"Error: {exception.Message}");
            }

            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Delete a file from current folder or specified path.
        /// </summary>
        public static void DeleteFile()
        {
            // Help message for user.
            WriteLine();
            WriteLine("Enter name of file (<Name file>)\n" +
                      $"  or direct path to file(<Disk name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Name file>) ");

            var filePath = ReadLine();

            // Error processing.
            try
            {
                // Check file exists.
                if (File.Exists(filePath))
                {
                    //Help message for user.
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Are you sure you want to delete. Enter <yes> or <no>");

                    var userChoose = ReadLine().ToLower();

                    while (userChoose != "no" && userChoose != "yes")
                    {
                        WriteLine("Incorrect input...");
                        WriteLine("Are you sure you want to delete");
                        userChoose = ReadLine().ToLower();
                    }

                    if (userChoose == "yes")
                    {
                        // Delete a file.
                        File.Delete(filePath);

                        // Help message for user.
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("File deleted successfully!");
                    }
                    else if (userChoose == "no")
                    {
                        // Help message for user.
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("The file has not been deleted");
                    }
                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("File not found.");
                }
            }
            catch (IOException exception)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Can't delete a file in this folder." +
                          $"\nError: {exception.Message}");
            }
            catch (Exception exception)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {exception.Message}");
            }

            WaitAnyKey();

            MainMenu();
        }


        /// <summary>
        /// Read content of text files and write it in console.
        /// </summary>
        public static void ReadFiles()
        {
            // Error processing.
            try
            {
                // Write path to needed files.
                var filesPath = GetFilesPath();

                WriteLine();
                
                var encoding = SelectEncoding();
                var fileText = filesPath.Select(file => File.ReadAllText(file, encoding)).ToList();
                
                if (fileText.Count()!=0)
                {
                    // Write contents of files in console.
                    ForegroundColor = ConsoleColor.White;
                    foreach (var message in fileText)
                    {
                        WriteLine(message);
                    }

                    // Help message for user.
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine();
                    WriteLine("Do you want save result in file? Enter <yes> or <no>.");
                    var userChoose = ReadLine().ToLower();

                    while (userChoose != "no" && userChoose != "yes")
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Incorrect input...");

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("Do you want save result in file? Enter <yes> or <no>.");

                        userChoose = ReadLine().ToLower();
                    }

                    if (userChoose == "yes")
                    {
                        // Help message for user.
                        ForegroundColor = ConsoleColor.White;
                        WriteLine("Enter <Name_file.txt>(Save in current folder)\n" +
                                  $"  or direct path to file: <Drive name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Name_file.txt>");

                        var path = ReadLine();
                        // Check file exists.
                        if (!File.Exists(path))
                        {
                            File.WriteAllLines(path, fileText.ToArray(), encoding);
                        }
                        else
                        {
                            // Help message for user.
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("File already exists.");
                        }
                    }
                    else if (userChoose == "no")
                    {
                        // Help message for user.
                        WriteLine("OK!");
                    }
                }
                else
                {
                    // Help message for user.
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Files are empty or not found.");
                }
                

            }
            catch (Exception exception)
            {
                // Help error message for user.
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine($"\nError: {exception.Message}");
            }


            WaitAnyKey();

            MainMenu();
        }

        /// <summary>
        /// Select text files for read and write content in console.
        /// </summary>
        /// <returns>Returns array strings of files path.</returns>
        public static string[] GetFilesPath()
        {
            var filesPath = new List<string>();

            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter path of files <Name file.txt>\n" +
                      $"  or direct path to file <Drive name:{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}Name file.txt>.");
            WriteLine("Enter </stop> to stop writing");

            ForegroundColor = ConsoleColor.White;
            var userfilePath = ReadLine();

            while (userfilePath.ToLower() != "/stop")
            {
                if (File.Exists(userfilePath))
                {
                    var filePath = userfilePath.Split(Path.DirectorySeparatorChar);
                    var fileName = filePath[^1].Split(".");
                    var extensionFile = fileName[^1];

                    if (extensionFile == "txt")
                    {
                        filesPath.Add(userfilePath);
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("File successfully found!");
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("File's extension is not \".txt\".");
                    }
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("File not found!");
                }

                ForegroundColor = ConsoleColor.White;
                userfilePath = ReadLine();
            }

            WriteLine();

            return filesPath.ToArray();
        }


        /// <summary>
        /// Write a text for text file.
        /// </summary>
        /// <returns>Returns array strings.</returns>
        public static string[] WriteText()
        {
            var userText = new List<string>();
            // Help message for user.
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter some text.");
            WriteLine("Enter </stop> to stop writing");

            ForegroundColor = ConsoleColor.White;
            var userString = ReadLine();

            while (userString.ToLower() != "/stop")
            {
                userText.Add(userString);

                userString = ReadLine();
            }

            WriteLine();

            return userText.ToArray();
        }


        /// <summary>
        /// Select a needed encoding for files.
        /// </summary>
        /// <returns>Returns chosen encoding.</returns>
        public static Encoding SelectEncoding()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine(new StringBuilder().Insert(0, " =", 8).ToString());
            WriteLine(
                $"||{"№".PadLeft(2),-3}" +
                $"|{"Name".PadLeft(8),-9}||"
            );
            WriteLine(new StringBuilder().Insert(0, " =", 8).ToString());
            WriteLine(
                $"||{"1".PadLeft(2),-3}" +
                $"|{"ASCII".PadLeft(8),-9}||\n"+
                $"||{"2".PadLeft(2),-3}" +
                $"|{"UTF32".PadLeft(8),-9}||\n"+
                $"||{"3".PadLeft(2),-3}" +
                $"|{"UTF7".PadLeft(8),-9}||\n"+
                $"||{"4".PadLeft(2),-3}" +
                $"|{"UTF8".PadLeft(8),-9}||\n"+
                $"||{"5".PadLeft(2),-3}" +
                $"|{"UNICODE".PadLeft(8),-9}||"
            );
            WriteLine(new StringBuilder().Insert(0, " =", 8).ToString());

            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter name of encoding");

            var userEncoding = ReadLine()?.ToUpper();
            switch (userEncoding)
            {
                case "ASCII":
                    WriteLine("The encoding has been selected : ASCII");
                    WriteLine();
                    return Encoding.ASCII;
                case "UTF32":
                    WriteLine("The encoding has been selected : UTF32");
                    WriteLine();
                    return Encoding.UTF32;
                case "UTF7":
                    WriteLine("The encoding has been selected : UTF7");
                    WriteLine();
                    return Encoding.UTF7;
                case "UTF8":
                    WriteLine("The encoding has been selected : UTF8");
                    WriteLine();
                    return Encoding.UTF8;
                case "UNICODE":
                    WriteLine("The encoding has been selected : UNICODE");
                    WriteLine();
                    return Encoding.Unicode;
                default:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Incorrect encoding.\nThe default encoding has been selected : UTF8");
                    WriteLine();
                    return Encoding.Default;
            }
        }
    }
}