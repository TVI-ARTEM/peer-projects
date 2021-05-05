using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Main
{
    public partial class FileManager
    {
        /// <summary>
        /// Help method for check valid drive name.
        /// </summary>
        /// <param name="source">Chosen drive.</param>
        /// <param name="systemDriveName">PC drive name.</param>
        /// <returns>Returns true or false depends on existence of drive.</returns>
        public static bool IsDriveNameValid(string source, string systemDriveName)
        {
            return (!string.IsNullOrEmpty(source) || !string.IsNullOrWhiteSpace(source)) 
                   && string.Equals(source, systemDriveName, StringComparison.InvariantCultureIgnoreCase);
        }
        
        /// <summary>
        /// Help method for check valid user drive.
        /// </summary>
        /// <param name="userDrive">Chosen drive.</param>
        /// <returns>Returns true or false depends on existence or ready to use of drive.</returns>
        public static bool IsDriveValid(string userDrive)
        {
            foreach (var drive in Drives)
            {
                if (IsDriveNameValid(userDrive + Path.DirectorySeparatorChar, drive.Name) && drive.IsReady)
                {
                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// Write current path to list.
        /// </summary>
        /// <param name="source">Current path.</param>
        /// <returns>Returns current path in list.</returns>
        public static List<string> InitializeCurrentPath(string source)
        {
            return source.Split(Path.DirectorySeparatorChar)
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();
        }
        
        /// <summary>
        /// Write current path to string.
        /// </summary>
        /// <returns>Returns current path in string.</returns>
        public static string InitializeCurrentPath()
        {
            return CurrentPath.Count == 1
                ? CurrentPath[0] + Path.DirectorySeparatorChar
                : Path.Combine(CurrentPath.ToArray());
        }
    }
}