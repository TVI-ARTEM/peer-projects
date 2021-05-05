using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel.Properties;

namespace Excel
{
    public partial class ChartForm : Form
    {
        /// <summary>
        /// Constructor to create chart form object.
        /// </summary>
        public ChartForm()
        {
            InitializeComponent();
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }


        #region Manage form

        /// <summary>
        /// Connecting libraries for the custom panel <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        /// <summary>
        /// Connecting libraries for the custom panel <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Change form position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeFormPosition();
        }

        /// <summary>
        /// Change form position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeFormPosition();
        }

        /// <summary>
        /// Change form position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeFormPosition();
        }


        /// <summary>
        /// Change from position by mouse down <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>. . 
        /// </summary>
        private void ChangeFormPosition()
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Roll this form.
        /// </summary>
        private void RollButton_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        /// <summary>
        /// Hide this from.
        /// </summary>
        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Close this form.
        /// </summary>
        private void ExitToolPanelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Close this form.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        /// <summary>
        /// Create new tab page in tab control.
        /// </summary>
        /// <param name="tabPage">New tab page.</param>
        public void SetNewTabPage(TabPage tabPage)
        {
            ChartTabControl.TabPages.Add(tabPage);
            ChartTabControl.SelectedIndex = ChartTabControl.TabCount - 1;
        }

        /// <summary>
        /// Read all data from tab pages and set it to list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnalyzeData.ChartTables = new Dictionary<string, Tuple<string, ChartType, DataTable>>();
            foreach (var sheetTabPage in ChartTabControl.TabPages.OfType<ChartTabPage>())
                foreach (var control in sheetTabPage.Controls)
                    switch (control)
                    {
                        case PieChartUserControl pieChartUserControl:
                            AnalyzeData.ChartTables.Add(AnalyzeData.ChartTables.Count.ToString(),
                                new Tuple<string, ChartType, DataTable>(
                                    ((DataTable)pieChartUserControl.BindingSource.DataSource).TableName, ChartType.Pie,
                                    (DataTable)pieChartUserControl.BindingSource.DataSource
                                ));
                            break;
                        case GraphChartUserControl graphChartUserControl:
                            AnalyzeData.ChartTables.Add(AnalyzeData.ChartTables.Count.ToString(),
                                new Tuple<string, ChartType, DataTable>(
                                    ((DataTable)graphChartUserControl.BindingSource.DataSource).TableName,
                                    ChartType.Graph,
                                    (DataTable)graphChartUserControl.BindingSource.DataSource
                                ));
                            break;
                        case ColumnChartUserControl columnChartUserControl:
                            AnalyzeData.ChartTables.Add(AnalyzeData.ChartTables.Count.ToString(),
                                new Tuple<string, ChartType, DataTable>(
                                    ((DataTable)columnChartUserControl.BindingSource.DataSource).TableName,
                                    ChartType.Column,
                                    (DataTable)columnChartUserControl.BindingSource.DataSource
                                ));
                            break;
                    }
        }


        /// <summary>
        /// Read all data from list and set this data to create new tab pages with charts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChartForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (AnalyzeData.ChartTables != null && AnalyzeData.ChartTables.Count != 0)
                    foreach (var key in AnalyzeData.ChartTables.Keys)
                    {
                        try
                        {
                            var chartType = AnalyzeData.ChartTables[key].Item2;
                            var chartTabPage = new ChartTabPage();

                            // Check data and set them into new tab page.
                            switch (chartType)
                            {
                                case ChartType.Pie:
                                    var pieChartControl = new PieChartUserControl(AnalyzeData.ChartTables[key].Item3)
                                    { Dock = DockStyle.Fill };
                                    chartTabPage = new ChartTabPage(pieChartControl)
                                    {
                                        Text = AnalyzeData.ChartTables[key].Item1
                                    };
                                    break;
                                case ChartType.Graph:
                                    var graphChartUserControl =
                                        new GraphChartUserControl(AnalyzeData.ChartTables[key].Item3, true)
                                        { Dock = DockStyle.Fill };
                                    chartTabPage = new ChartTabPage(graphChartUserControl)
                                    {
                                        Text = AnalyzeData.ChartTables[key].Item1
                                    };
                                    break;
                                case ChartType.Column:
                                    var columnChartUserControl =
                                        new ColumnChartUserControl(AnalyzeData.ChartTables[key].Item3)
                                        { Dock = DockStyle.Fill };
                                    chartTabPage = new ChartTabPage(columnChartUserControl)
                                    {
                                        Text = AnalyzeData.ChartTables[key].Item1
                                    };
                                    break;
                            }

                            SetNewTabPage(chartTabPage);
                        }
                        catch
                        {
                            // ignored
                        }
                    }


                ChartTabControl.SelectedIndex = ChartTabControl.TabCount - 1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.errorBox, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Remove selected tab page from tab control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseThisTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChartTabControl.TabPages.RemoveAt(ChartTabControl.SelectedIndex);
            }
            catch
            {
                // ignored
            }
        }
    }
}