using System;
using System.Collections.Generic;
using System.IO;

namespace Main
{
    public partial class FileManager
    {
        public static List<string> CurrentPath;
        public static DriveInfo[] Drives;


        /// <summary>
        /// Main method - start program.
        /// </summary>
        public static void Main(string[] args)
        {
            InitializeFileManager();
            
            // Start Menu
            MainMenu();
        }


        /// <summary>
        /// Get info of current path.
        /// </summary>
        public static void InitializeFileManager()
        {
            CurrentPath = InitializeCurrentPath(Environment.CurrentDirectory);
        }
    }
}