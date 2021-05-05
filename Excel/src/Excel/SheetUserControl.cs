using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel.Properties;

namespace Excel
{
    public partial class SheetUserControl : UserControl
    {
        public BindingSource BindingSource = new();

        /// <summary>
        /// Constructor to create sheet user control object.
        /// </summary>
        /// <param name="dataTable"></param>
        public SheetUserControl(DataTable dataTable)
        {
            InitializeComponent();

            SetSettings(dataTable);
        }


        /// <summary>
        /// Set data and settings to user control.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        private void SetSettings(DataTable dataTable)
        {
            BindingSource.DataSource = dataTable;

            dataGridView.DataSource = BindingSource;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Font = new Font(
                new FontFamily("Times New Roman"),
                16,
                FontStyle.Regular,
                GraphicsUnit.Pixel);

            dataGridView.ContextMenuStrip = CreateContextMenuStrip();


            ValueXComboBox.DataSource = GetColumnsName(dataTable);
            LegendComboBox.DataSource = GetColumnsName(dataTable);
            ValueYComboBox.DataSource = GetColumnsName(dataTable);
            ValuesListBox.DataSource = GetColumnsName(dataTable);
            ChartTypeComboBox.DataSource = Enum.GetValues(typeof(ChartType));
        }

        /// <summary>
        /// Create context menu strip for data grid view.
        /// </summary>
        /// <returns>Context menu strip.</returns>
        private ContextMenuStrip CreateContextMenuStrip()
        {
            // Create tools for new context menu strip.

            var newContextMenuStrip = new ContextMenuStrip();
            var selectAllRow = new ToolStripMenuItem("Select All Row", Resources.SelectAll_16x, SelectAllRow);
            var selectAllColumn =
                new ToolStripMenuItem("Select All Column", Resources.SelectAll_16x, SelectAllColumn);

            newContextMenuStrip.Items.AddRange(new ToolStripItem[] { selectAllRow, selectAllColumn });


            return newContextMenuStrip;
        }

        /// <summary>
        /// Select all row at dataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllRow(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                for (var columnIndex = 0; columnIndex < dataGridView.ColumnCount; columnIndex++)
                    dataGridView[columnIndex, cell.RowIndex].Selected = true;
        }

        /// <summary>
        /// Select all column at dataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllColumn(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                for (var rowIndex = 0; rowIndex < dataGridView.RowCount; rowIndex++)
                    dataGridView[cell.ColumnIndex, rowIndex].Selected = true;
        }

        /// <summary>
        /// Get columns name from dataGridView.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        /// <returns>Column Names.</returns>
        private static List<string> GetColumnsName(DataTable dataTable)
        {
            return (from DataColumn dataColumn in dataTable.Columns select dataColumn.ColumnName).ToList();
        }

        /// <summary>
        /// Change comboBox size when dropDown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ComboBox_DropDown(object sender, EventArgs e)
        {
            if (sender is not ComboBox comboBox) return;

            var g = comboBox.CreateGraphics();

            var highest =
                (from object item in comboBox.Items
                 select g.MeasureString(item.ToString(), comboBox.Font)
                    into textLength
                 select textLength.Width).Prepend(0).Max();

            if (highest > 0) comboBox.DropDownWidth = (int)highest;
        }

        /// <summary>
        /// Change comboBox size when dropDown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValueXComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox_DropDown(sender, e);
        }
        /// <summary>
        /// Change comboBox size when dropDown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValueYComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox_DropDown(sender, e);
        }
        /// <summary>
        /// Change comboBox size when dropDown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LegendComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox_DropDown(sender, e);
        }

        /// <summary>
        /// Change enabled state for some controls when selected index in charTypeComboBox changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChartTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ChartType)ChartTypeComboBox.SelectedItem)
            {
                case ChartType.Pie:
                    ValueXComboBox.Enabled = true;
                    ValueYComboBox.Enabled = false;
                    SortDataCheckBox.Enabled = false;
                    ValuesListBox.Enabled = false;
                    LegendComboBox.Enabled = false;
                    break;
                case ChartType.Graph:
                    ValueXComboBox.Enabled = true;
                    ValueYComboBox.Enabled = true;
                    SortDataCheckBox.Enabled = true;
                    ValuesListBox.Enabled = false;
                    LegendComboBox.Enabled = false;
                    break;
                case ChartType.Column:
                    ValueXComboBox.Enabled = false;
                    ValueYComboBox.Enabled = false;
                    SortDataCheckBox.Enabled = false;
                    ValuesListBox.Enabled = true;
                    LegendComboBox.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// Create new chart tab page and open chart form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateChartButton_Click(object sender, EventArgs e)
        {
            AnalyzeData.OpenChartForm();
            try
            {
                switch ((ChartType)ChartTypeComboBox.SelectedItem)
                {
                    case ChartType.Pie:
                        CreatePieChart();
                        break;
                    case ChartType.Graph:
                        CreateGraphChart();
                        break;
                    case ChartType.Column:
                        CreateColumnChart();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.errorBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Create pie chart and open new chart tab page.
        /// </summary>
        private void CreatePieChart()
        {
            var datable = new DataTable(ValueXComboBox.SelectedItem.ToString());
            InitializeDataTable(datable);

            // Set new column.
            GetDataColumn(ValueXComboBox.SelectedItem.ToString(), datable);

            // Create chart and new tab page.
            var pieChart = new PieChartUserControl(datable) { Dock = DockStyle.Fill };

            (AnalyzeData.ChartForm as ChartForm)?.SetNewTabPage(new ChartTabPage(pieChart)
            { Text = datable.TableName });
        }

        /// <summary>
        /// Create graph chart and open new chart tab page.
        /// </summary>
        private void CreateGraphChart()
        {
            var datable = new DataTable(ValueXComboBox.SelectedItem.ToString());
            InitializeDataTable(datable);

            // Set new columns.
            GetDataColumn(ValueXComboBox.SelectedItem.ToString(), datable);
            GetDataColumn(ValueYComboBox.SelectedItem.ToString(), datable);

            // Create chart and new tab page.
            var graphChart = new GraphChartUserControl(datable, SortDataCheckBox.Checked) { Dock = DockStyle.Fill };

            (AnalyzeData.ChartForm as ChartForm)?.SetNewTabPage(new ChartTabPage(graphChart)
            { Text = datable.TableName });
        }

        /// <summary>
        /// Create column chart and open new chart tab page.
        /// </summary>
        private void CreateColumnChart()
        {
            var datable = new DataTable(LegendComboBox.SelectedItem.ToString());
            InitializeDataTable(datable);

            // Set new columns.
            GetDataColumn(LegendComboBox.SelectedItem.ToString(), datable);
            foreach (var item in ValuesListBox.SelectedItems) GetDataColumn(item.ToString(), datable);

            // Create chart and new tab page.
            var columnChart = new ColumnChartUserControl(datable) { Dock = DockStyle.Fill };
            (AnalyzeData.ChartForm as ChartForm)?.SetNewTabPage(new ChartTabPage(columnChart)
            { Text = datable.TableName });
        }

        /// <summary>
        /// Create rows to dataTable.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        private void InitializeDataTable(DataTable dataTable)
        {
            for (var i = 0; i < dataGridView.RowCount - 1; i++)
            {
                try
                {
                    dataTable.Rows.Add(dataTable.NewRow());
                }
                catch
                {
                    // ignored
                }
            }
        }


        /// <summary>
        /// Get data from selected column.
        /// </summary>
        /// <param name="columnName">Selected column name.</param>
        /// <param name="dataTable">Data table.</param>
        private void GetDataColumn(string columnName, DataTable dataTable)
        {
            // Create new data column and add it to data table.
            var dataColumn = new DataColumn
            {
                ColumnName = dataGridView.Columns[columnName].Name,
                Caption = dataGridView.Columns[columnName].HeaderText
            };
            dataTable.Columns.Add(dataColumn);

            // Add values from dataGridView to new column.
            for (var i = 0; i < dataGridView.RowCount - 1; i++)
            {
                try
                {
                    dataTable.Rows[i][dataColumn.ColumnName] = dataGridView.Rows[i].Cells[columnName].Value;
                }
                catch
                {
                    // ignored
                }
            }
        }
    }
}