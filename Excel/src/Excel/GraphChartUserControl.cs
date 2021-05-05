using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Excel.Properties;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Excel
{
    public partial class GraphChartUserControl : UserControl
    {
        /// <summary>
        /// Limit on data numbers.
        /// </summary>
        private const int MaxLength = 100;
        public BindingSource BindingSource = new();

        /// <summary>
        /// Constructor to create new graph chart.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        /// <param name="sortData">Sort data or not.</param>
        public GraphChartUserControl(DataTable dataTable, bool sortData)
        {
            InitializeComponent();
            BindingSource.DataSource = dataTable;
            SetData(dataTable, sortData);
        }


        /// <summary>
        /// Set data from dataTable.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        /// <param name="sortData">Sort data or not.</param>
        private void SetData(DataTable dataTable, bool sortData)
        {
            var valueX = new List<double>();
            var valueY = new List<double>();

            GetData(dataTable, sortData, valueX, valueY);

            SetChartSetting(dataTable, valueX, valueY);

            SetLabelData(valueX, valueY);
        }


        /// <summary>
        /// Set data to labels.
        /// </summary>
        /// <param name="valueX">ValueX list.</param>
        /// <param name="valueY">ValueY list.</param>
        private void SetLabelData(List<double> valueX, List<double> valueY)
        {
            AVGXLabel.Text = string.Format(Resources.avgColumn, valueX.Average().ToString("F2"));
            AVGYLabel.Text = string.Format(Resources.avgColumn, valueY.Average().ToString("F2"));
            MedianXLabel.Text = string.Format(Resources.medianColumn, GetMedian(valueX).ToString("F2"));
            MedianYLabel.Text = string.Format(Resources.medianColumn, GetMedian(valueY).ToString("F2"));
            VarianceXLabel.Text = string.Format(Resources.varianceColumn, GetVariance(valueX).ToString("F2"));
            VarianceYLabel.Text = string.Format(Resources.varianceColumn, GetVariance(valueY).ToString("F2"));
            SAXLabel.Text = string.Format(Resources.saColumn, Math.Sqrt(GetVariance(valueX)).ToString("F2"));
            SAYLabel.Text = string.Format(Resources.saColumn, Math.Sqrt(GetVariance(valueY)).ToString("F2"));
        }

        /// <summary>
        /// Get variance from column.
        /// </summary>
        /// <param name="values">Column data.</param>
        /// <returns>Variance.</returns>
        private static double GetVariance(List<double> values)
        {
            var avg = values.Average();
            var sum = values.Sum(value => Math.Pow(value - avg, 2));

            return sum / values.Count;
        }

        /// <summary>
        /// Get median from column.
        /// </summary>
        /// <param name="values">Column data.</param>
        /// <returns>Median.</returns>
        private static double GetMedian(List<double> values)
        {
            var mid = values.Count / 2;
            return (values.Count % 2 != 0) ? values[mid] : (values[mid] + values[mid - 1]) / 2;
        }

        /// <summary>
        /// Set data to chart from data lists.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        /// <param name="valueX">ValueX list.</param>
        /// <param name="valueY">ValueY list.</param>
        private void SetChartSetting(DataTable dataTable, List<double> valueX, List<double> valueY)
        {
            // Create points to draw chart.
            var observablePoint = new ChartValues<ObservablePoint>();

            observablePoint.AddRange(valueX.Select((t, i) => new ObservablePoint(t, valueY[i])).ToList());

            cartesianChart.Series = new SeriesCollection(Mappers.Xy<ObservablePoint>()
                .X(point => Math.Log10(point.X))
                .Y(point => point.Y))
            {
                new LineSeries()
                {
                    Title = $"{dataTable.Columns[0].ColumnName} --> {dataTable.Columns[1].ColumnName}",
                    Values = observablePoint
                }
            };

            // Create new axis and some settings.
            cartesianChart.AxisX.Add(new Axis
            {
                Title = dataTable.Columns[0].ColumnName,
                LabelFormatter = value => Math.Pow(10, value).ToString("N"),
                MinValue = double.NaN,
                MaxValue = double.NaN
            });

            cartesianChart.AxisY.Add(new Axis
            {
                Title = dataTable.Columns[1].ColumnName,
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
        /// <param name="sortData">Sort data or not.</param>
        /// <param name="valueX">ValueX list.</param>
        /// <param name="valueY">ValueY list.</param>
        private static void GetData(DataTable dataTable, bool sortData, List<double> valueX, List<double> valueY)
        {
            // Get data from first column.
            for (var i = 0; i < dataTable.Rows.Count; i++)
                try
                {
                    if (double.TryParse(dataTable.Rows[i].ItemArray[0].ToString(), NumberStyles.Any,
                        CultureInfo.InvariantCulture, out var result))
                        valueX.Add(result);
                }
                catch
                {
                    // ignored
                }

            // Get data from second column.
            for (var i = 0; i < dataTable.Rows.Count; i++)
                try
                {
                    if (double.TryParse(dataTable.Rows[i].ItemArray[1].ToString(), NumberStyles.Any,
                        CultureInfo.InvariantCulture, out var result))
                        valueY.Add(result);
                }
                catch
                {
                    // ignored
                }

            // Check data.
            if (valueX.Count != valueY.Count || valueX.Count == 0 || valueY.Count == 0)
                throw new DataException("Incorrect data. Not enough data");

            if (sortData)
            {
                valueX.Sort();
                valueY.Sort();
            }

            // Remove if lists have a lot of data.
            if (valueX.Count > MaxLength) valueX.RemoveRange(MaxLength, valueX.Count - MaxLength);

            if (valueY.Count > MaxLength) valueY.RemoveRange(MaxLength, valueY.Count - MaxLength);
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