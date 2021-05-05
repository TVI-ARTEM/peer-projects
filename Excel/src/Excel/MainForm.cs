using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Excel
{
    public partial class MainForm : Form
    {
        public Form ActiveChildForm { get; set; }

        /// <summary>
        /// Constructor to create main form object.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            OpenChildForm(new HomeForm { Owner = this });
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        /// <summary>
        /// Open child form in panel <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        /// <param name="childForm"></param>
        private void OpenChildForm(Form childForm)
        {
            // Close current form.
            ActiveChildForm?.Close();

            // Set some settings and show it.
            ActiveChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            PageNameLabel.Text = childForm.Text;
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
        private void PageNameLabel_MouseDown(object sender, MouseEventArgs e)
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
            Application.Exit();
        }

        /// <summary>
        /// Close this form.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        /// <summary>
        /// Open home form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HomeForm { Owner = this });
        }


        /// <summary>
        /// Open sheet form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowSheetButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SheetForm { Owner = this });
        }

        /// <summary>
        /// Open chart form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowChartButton_Click(object sender, EventArgs e)
        {
            AnalyzeData.OpenChartForm();
        }

        /// <summary>
        /// Load data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            AnalyzeData.ApplicationLoad();
        }

        /// <summary>
        /// Save data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnalyzeData.ApplicationClose();
        }
    }
}