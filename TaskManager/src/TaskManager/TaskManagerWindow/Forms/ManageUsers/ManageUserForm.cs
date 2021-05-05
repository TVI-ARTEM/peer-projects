using System;
using System.Windows.Forms;

namespace TaskManagerWindow.Forms.ManageUsers
{
    public partial class ManageUserForm : Form
    {
        /// <summary>
        /// Opened child form.
        /// </summary>
        public Form ActiveChildForm { get; set; }


        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public ManageUserForm()
        {
            InitializeComponent();
            OpenChildForm(new ShowUsersForm {Owner = this});
        }

        /// <summary>
        /// Open show users form.
        /// </summary>
        private void ShowUserButton_Click(object sender, EventArgs e) => OpenChildForm(new ShowUsersForm {Owner = this});

        /// <summary>
        /// Open hire user form.
        /// </summary>
        private void HireUserButton_Click(object sender, EventArgs e) => OpenChildForm(new HireUserForm {Owner = this});

        /// <summary>
        /// Open remove user form.
        /// </summary>
        private void FireUserButton_Click(object sender, EventArgs e) => OpenChildForm(new RemoveUserForm {Owner = this});

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
        }
    }
}