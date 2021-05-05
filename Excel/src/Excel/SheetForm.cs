using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using Excel.Properties;

namespace Excel
{
    public partial class SheetForm : Form
    {
        /// <summary>
        /// Constructor to create sheet form object.
        /// </summary>
        public SheetForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open new file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                using var fileDialog = new OpenFileDialog
                { Filter = Resources.fileDialogFilter, ValidateNames = true, Multiselect = false };

                if (fileDialog.ShowDialog() != DialogResult.OK) return;
                var newTabPage = new SheetTabPage(ReadCsv(fileDialog.FileName))
                { Text = Path.GetFileName(fileDialog.FileName) };
                SheetsTabControl.TabPages.Add(newTabPage);
                SheetsTabControl.SelectedIndex = SheetsTabControl.TabCount - 1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.errorBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Read Csv file by csv helper.
        /// </summary>
        /// <param name="filename">File name.</param>
        /// <returns>File data table.</returns>
        private static DataTable ReadCsv(string filename)
        {
            var dataTable = new DataTable(Path.GetFileName(filename));
            // Check file.
            if (!File.Exists(filename)) throw new FileNotFoundException("There are some problems...");

            // set some settings.
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
                MissingFieldFound = null,
                TrimOptions = TrimOptions.Trim
            };


            using var sr = new StreamReader(filename);
            using var csv = new CsvReader(sr, config);
            using var dr = new CsvDataReader(csv);
            // Load data.
            dataTable.Load(dr);

            // Check data.
            CheckDataTable(ref dataTable);

            return dataTable;
        }

        /// <summary>
        /// Close selected tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SheetsTabControl.TabCount == 0) return;

            SheetsTabControl.TabPages.Remove(SheetsTabControl.SelectedTab);
        }

        /// <summary>
        /// Check data to correct.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        private static void CheckDataTable(ref DataTable dataTable)
        {
            for (var i = 0; i < dataTable.Rows.Count; i++)
                for (var j = 0; j < dataTable.Columns.Count; j++)
                {
                    var cell = Convert.ToString(dataTable.Rows[i][j]);
                    if (cell != string.Empty) continue;

                    dataTable.Rows.RemoveAt(i--);
                    break;
                }
        }

        /// <summary>
        /// Save data tables from tab pages.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SheetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                AnalyzeData.SheetTables = new List<DataTable>();
                foreach (var sheetTabPage in SheetsTabControl.TabPages.OfType<SheetTabPage>())
                {
                    foreach (var control in sheetTabPage.Controls)
                    {
                        if (control is SheetUserControl sheetUserControl)
                            AnalyzeData.SheetTables.Add((DataTable)sheetUserControl.BindingSource.DataSource);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.errorBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open new tab pages by data tables lists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SheetForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (AnalyzeData.SheetTables != null && AnalyzeData.ChartTables.Count != 0)

                    // create new tab page.
                    foreach (var newTabPage in AnalyzeData.SheetTables
                        .Select(sheetTable => new SheetTabPage(sheetTable)
                        { Text = sheetTable.TableName })
                    )
                    {
                        SheetsTabControl.TabPages.Add(newTabPage);
                    }

                SheetsTabControl.SelectedIndex = SheetsTabControl.TabCount - 1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.errorBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}