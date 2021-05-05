using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;
using Excel.Properties;
using LiveCharts;
using LiveCharts.Wpf;
using Color = System.Windows.Media.Color;

namespace Excel
{
    public partial class ColumnChartUserControl : UserControl
    {
        /// <summary>
        /// Limit on data numbers.
        /// </summary>
        private const int MaxLength = 100;
        public BindingSource BindingSource = new();

        /// <summary>
        /// Constructor to create new column chart.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        public ColumnChartUserControl(DataTable dataTable)
        {
            InitializeComponent();
            BindingSource.DataSource = dataTable;
            SetData(dataTable);
        }

        /// <summary>
        /// Set data from dataTable.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        private void SetData(DataTable dataTable)
        {
            var titles = new List<string>();

            var labels = (from DataColumn column in dataTable.Columns select column.ColumnName).ToList();

            var values = new List<ChartValues<double>>();

            GetData(dataTable, labels, titles, values);

            SetChartSetting(titles, values, labels);
        }

        /// <summary>
        /// Set data to chart from data lists.
        /// </summary>
        /// <param name="titles">Titles list.</param>
        /// <param name="values">Values list.</param>
        /// <param name="labels">Labels list.</param>
        private void SetChartSetting(List<string> titles, List<ChartValues<double>> values, List<string> labels)
        {
            var series = new SeriesCollection();

            // Create new series.
            for (var i = 0; i < titles.Count; i++)
                series.Add(new ColumnSeries
                {
                    Title = titles[i],
                    Values = values[i]
                });

            // Create new axis and some settings.
            cartesianChart.Series = series;
            cartesianChart.AxisX.Add(new Axis
            {
                Labels = labels.ToArray(),
                MinValue = double.NaN,
                MaxValue = double.NaN
            });

            cartesianChart.AxisY.Add(new Axis
            {
                LabelFormatter = value => value.ToString("N"),
                MinValue = double.NaN,
                MaxValue = double.NaN
            });

            cartesianChart.LegendLocation = LegendLocation.Right;

            cartesianChart.Zoom = ZoomingOptions.Xy;
        }

        /// <summary>
        /// Get data from data table.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        /// <param name="labels">Labels list.</param>
        /// <param name="titles">Titles list.</param>
        /// <param name="values">Values list.</param>
        private static void GetData(DataTable dataTable, List<string> labels, List<string> titles,
            List<ChartValues<double>> values)
        {
            labels.RemoveAt(0);
            for (var i = 0; i < dataTable.Rows.Count; i++) titles.Add(dataTable.Rows[i].ItemArray[0].ToString());
            for (var i = 0; i < dataTable.Rows.Count; i++)
            {
                var newValues = new ChartValues<double>();
                for (var j = 1; j < dataTable.Columns.Count; j++)
                    try
                    {
                        if (double.TryParse(dataTable.Rows[i].ItemArray[j].ToString(), NumberStyles.Any,
                            CultureInfo.InvariantCulture, out var result))
                            newValues.Add(result);
                    }
                    catch
                    {
                        // ignored
                    }

                values.Add(newValues);
            }

            CheckData(titles, labels, values);
        }

        /// <summary>
        /// Check received data.
        /// </summary>
        /// <param name="titles">Titles list.</param>
        /// <param name="values">Values list.</param>
        /// <param name="labels">Labels list.</param>
        private static void CheckData(List<string> titles, List<string> labels, List<ChartValues<double>> values)
        {
            if (titles.Count != values.Count) throw new DataException("Incorrect data");

            if (values.Any(listValue => listValue.Count != labels.Count)) throw new DataException("Incorrect data");

            if (titles.Count > MaxLength) titles.RemoveRange(MaxLength, titles.Count - MaxLength);

            if (values.Count > MaxLength) values.RemoveRange(MaxLength, values.Count - MaxLength);
        }

        /// <summary>
        /// Change series color when click on column.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="chartPoint"></param>
        private void CartesianChart_DataClick(object sender, ChartPoint chartPoint)
        {
            try
            {
                using var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    ((ColumnSeries)chartPoint.SeriesView).Fill = new SolidColorBrush(
                        Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G,
                            colorDialog.Color.B));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.errorBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save chart to bitmap.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create new bitmap and draw chart to this bitmap.
                var bmp = new Bitmap(cartesianChart.Width, cartesianChart.Height);
                cartesianChart.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));


                using var saveFileDialog = new SaveFileDialog
                {
                    Filter = Resources.saveFileDialogFilter
                };

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                // Save chart to png file.
                bmp.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.errorBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}