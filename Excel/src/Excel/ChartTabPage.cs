using System.Windows.Forms;

namespace Excel
{
    public partial class ChartTabPage : TabPage
    {
        /// <summary>
        /// Chart of this tab page.
        /// </summary>
        public Control Chart;

        /// <summary>
        /// Constructor to create new tab page.
        /// </summary>
        public ChartTabPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor to create new tab page with chart.
        /// </summary>
        /// <param name="chart">New Chart.</param>
        public ChartTabPage(Control chart) : this()
        {
            Chart = chart;
            Chart.Select();
            Controls.Add(Chart);
        }

    }
}