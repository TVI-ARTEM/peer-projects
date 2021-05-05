using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;
using Excel.Properties;
using LiveCharts;
using LiveCharts.Wpf;
using Axis = LiveCharts.Wpf.Axis;
using Color = System.Windows.Media.Color;
using SeriesCollection = LiveCharts.SeriesCollection;

namespace Excel
{
    public partial class PieChartUserControl : UserControl
    {        
        /// <summary>
        /// Limit on data numbers.
        /// </summary>
        private const int MaxLength = 125;
        public BindingSource BindingSource = new();

        /// <summary>
        /// Constructor to create new pie chart.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        public PieChartUserControl(DataTable dataTable)
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
            var series = new SeriesCollection();
            var nameValues = new List<string>();

            var values = GetData(dataTable, nameValues);

            SetChartSetting(values, series);
        }

        /// <summary>
        /// Set data to chart from data lists.
        /// </summary>
        /// <param name="values">Values list.</param>
        /// <param name="series">Series list.</param>
        private void SetChartSetting(Dictionary<string, double> values, SeriesCollection series)
        {
            static string LabelPoint(ChartPoint chartPoint)
            {
                return $"{chartPoint.Y} ({chartPoint.Participation:P})";
            }

            // Create new pie series and set some settings.
            foreach (var pieSeries in values.Keys.Select(key => new PieSeries
            {
                Title = key,
                Values = new ChartValues<double>(new[] { values[key] }),
                FontSize = 10,
                LabelPoint = LabelPoint
            }))
                series.Add(pieSeries);

            pieChart.Series = series;
            pieChart.LegendLocation = LegendLocation.Right;

            series = new SeriesCollection();
            // Create new column series and set some settings.
            foreach (var columnSeries in values.Keys.Select(key => new ColumnSeries()
            {
                Title = key,
                Values = new ChartValues<double>(new[] { values[key] }),
                FontSize = 10,
            }))
                series.Add(columnSeries);

            cartesianChart.Series = series;
            cartesianChart.LegendLocation = LegendLocation.Right;
            cartesianChart.AxisX.Add(new Axis
            {
                MinValue = double.NaN,
                MaxValue = double.NaN
            });
            cartesianChart.AxisY.Add(new Axis
            {
                MinValue = double.NaN,
                MaxValue = double.NaN
            });

            cartesianChart.Zoom = ZoomingOptions.Xy;
        }

        /// <summary>
        /// Get data from dataTable.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        /// <param name="nameValues">NameValues list.</param>
        /// <returns></returns>
        private static Dictionary<string, double> GetData(DataTable dataTable, List<string> nameValues)
        {
            for (var i = 0; i < dataTable.Rows.Count; i++) nameValues.Add(dataTable.Rows[i].ItemArray[0].ToString());

            var values = nameValues.Distinct().ToDictionary(names => names, names => 0d);
            var names = values.Keys.ToList();
            // Remove data if it contains more than limit.
            for (var i = MaxLength; i < names.Count; i++)
            {
                values.Remove(names[i]);
            }

            for (var i = 0; i < values.Count; i++)
            {
                var thisKey = values.Keys.ToList()[i];

                foreach (var _ in nameValues.Where(checkKey => thisKey.Equals(checkKey))) values[thisKey]++;
            }

            return values;
        }

        /// <summary>
        /// Change color series when click on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="chartPoint"></param>
        private void CartesianChart_DataClick(object sender, ChartPoint chartPoint)
        {
            try
            {
                using var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    ((ColumnSeries)chartPoint.SeriesView).Fill = new SolidColorBrush(
                        Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G,
                            colorDialog.Color.B));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.errorBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Change color series when click on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="chartPoint"></param>
        private void PieChart_DataClick(object sender, ChartPoint chartPoint)
        {
            try
            {
                using var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    ((PieSeries)chartPoint.SeriesView).Fill = new SolidColorBrush(
                        Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G,
                            colorDialog.Color.B));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.errorBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save charts to bitmap.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create new bitmap and draw chart to this bitmap.
                var bmpCartesian = new Bitmap(cartesianChart.Width, cartesianChart.Height);
                cartesianChart.DrawToBitmap(bmpCartesian, new Rectangle(0, 0, bmpCartesian.Width, bmpCartesian.Height));

                var bmpPie = new Bitmap(pieChart.Width, pieChart.Height);
                pieChart.DrawToBitmap(bmpPie, new Rectangle(0, 0, bmpPie.Width, bmpPie.Height));

                using var saveFileDialog = new SaveFileDialog
                {
                    Filter = Resources.saveFileDialogFilter
                };

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                // Save chart to png file.
                bmpCartesian.Save(Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName),
                        Path.GetFileNameWithoutExtension(saveFileDialog.FileName) + "Cartesian" +
                        Path.GetExtension(saveFileDialog.FileName))
                    , ImageFormat.Png);
                bmpPie.Save(
                    Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName),
                        Path.GetFileNameWithoutExtension(saveFileDialog.FileName) + "Pie" +
                        Path.GetExtension(saveFileDialog.FileName)), ImageFormat.Png);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.errorBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}