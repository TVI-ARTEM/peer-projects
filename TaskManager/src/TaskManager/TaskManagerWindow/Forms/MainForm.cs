using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TaskManagerWindow.Forms.ManageUsers;
using TaskManagerWindow.Forms.MangeTasks;

namespace TaskManagerWindow.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Opened child form.
        /// </summary>
        public Form ActiveChildForm { get; set; }

        /// <summary>
        /// Constructor mainForm.
        /// </summary>
        public MainForm()
        {
            // Set up some settings and data.

            InitializeComponent();
            Manager.ApplicationLoad();

            OpenChildForm(new HomeForm());
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }


        #region Open new form.

        /// <summary>
        /// Open Home Form.
        /// </summary>
        private void HomeButton_Click(object sender, EventArgs e) => OpenChildForm(new HomeForm {Owner = this});

        /// <summary>
        /// Open About Form.
        /// </summary>
        private void AboutButton_Click(object sender, EventArgs e) => OpenChildForm(new AboutFom {Owner = this});

        /// <summary>
        /// Open Manage User Form.
        /// </summary>
        private void ManageUserButton_Click(object sender, EventArgs e) => OpenChildForm(new ManageUserForm {Owner = this});

        /// <summary>
        /// Open Manage Task Form.
        /// </summary>
        private void ManageTaskButton_Click(object sender, EventArgs e) => OpenChildForm(new ManageTaskForm {Owner = this});

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

        #endregion

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

        private void MainPanel_MouseDown(object sender, MouseEventArgs e) => ChangeFormPosition();


        private void LogoPanel_MouseDown(object sender, MouseEventArgs e) => ChangeFormPosition();


        private void PageNameLabel_MouseDown(object sender, MouseEventArgs e) => ChangeFormPosition();


        private void LogoLabel_MouseDown(object sender, MouseEventArgs e) => ChangeFormPosition();

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
        private void RollCircleButton_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        /// <summary>
        /// Hide this from.
        /// </summary>
        private void HideCircleButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Close this form.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Close this form.
        /// </summary>
        private void ExitCircleButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}