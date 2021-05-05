using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Excel
{
    public static class AnalyzeData
    {
        /// <summary>
        /// Chart form contains charts.
        /// </summary>
        public static Form ChartForm { get; private set; }
        /// <summary>
        /// Sheet tables.
        /// </summary>
        public static List<DataTable> SheetTables;
        /// <summary>
        /// Chart tables.
        /// </summary>
        public static Dictionary<string, Tuple<string, ChartType, DataTable>> ChartTables;
        /// <summary>
        /// Path to hidden application directory.
        /// </summary>
        public const string AnalyzePath = "AnalyzeData";
        /// <summary>
        /// Path to application settings directory.
        /// </summary>
        public const string SettingsPath = "Settings";
        /// <summary>
        /// Path to sheet tables json file.
        /// </summary>
        public const string SheetTablesPath = "SheetTaables.json";
        /// <summary>
        /// Path to chart tables json file.
        /// </summary>
        public const string ChartTablesPath = "ChartTables.json";

        /// <summary>
        /// Open chart from.
        /// </summary>
        public static void OpenChartForm()
        {
            if (ChartForm == null || ChartForm.IsDisposed) ChartForm = new ChartForm();

            ChartForm.Activate();
            ChartForm.Show();
        }

        /// <summary>
        /// Set application setting when load.
        /// </summary>
        public static void ApplicationLoad()
        {
            try
            {
                // Create hidden folder
                var analyzeDirectory = Directory.CreateDirectory(AnalyzePath);
                analyzeDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                analyzeDirectory.CreateSubdirectory(SettingsPath);
                SheetTables = new List<DataTable>();
                ChartTables = new Dictionary<string, Tuple<string, ChartType, DataTable>>();

                // Open data files.


                OpenFile(ref SheetTables, SheetTablesPath);
                OpenFile(ref ChartTables, ChartTablesPath);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Save data when closed.
        /// </summary>
        public static void ApplicationClose()
        {
            SaveFile(SheetTables, SheetTablesPath);
            SaveFile(ChartTables, ChartTablesPath);
        }

        /// <summary>
        /// Open necessary file and get data.
        /// </summary>
        /// <typeparam name="T">Destination object type.</typeparam>
        /// <param name="destinationObject">Destination object.</param>
        /// <param name="filePath">File path.</param>
        public static void OpenFile<T>(ref T destinationObject, string filePath)
        {
            try
            {
                // Check data.
                var objectFile = Path.Combine(AnalyzePath, SettingsPath, filePath);
                if (!File.Exists(objectFile)) return;

                using var fileStream = new FileStream(objectFile, FileMode.Open, FileAccess.Read);
                using var streamReader = new StreamReader(fileStream);

                // Read file.
                var jsonObject = streamReader.ReadToEnd();

                var options = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All,
                    PreserveReferencesHandling = PreserveReferencesHandling.All
                };

                // Set data.
                destinationObject = JsonConvert.DeserializeObject<T>(jsonObject, options);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Save some object to file.
        /// </summary>
        /// <typeparam name="T">Source object type.</typeparam>
        /// <param name="sourceObject">Source object.</param>
        /// <param name="filePath">File path.</param>
        public static void SaveFile<T>(T sourceObject, string filePath)
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

                var objectInfo = JsonConvert.SerializeObject(sourceObject, options);


                // Save file.
                using var fileStream = new FileStream(Path.Combine(AnalyzePath, SettingsPath, filePath),
                    FileMode.Create,
                    FileAccess.Write);
                using var streamWriter = new StreamWriter(fileStream);

                streamWriter.WriteLine(objectInfo);
            }
            catch
            {
                // ignored
            }
        }
    }
}