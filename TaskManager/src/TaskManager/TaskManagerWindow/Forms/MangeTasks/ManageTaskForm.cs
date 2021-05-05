using System;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class ManageTaskForm : Form
    {
        /// <summary>
        /// Opened child form.
        /// </summary>
        public Form ActiveChildForm { get; set; }

        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public ManageTaskForm()
        {
            InitializeComponent();
            OpenChildForm(new ManageProjectForm { Owner = this });
        }

        /// <summary>
        /// Open manage project form.
        /// </summary>
        private void ManageProjectButton_Click(object sender, EventArgs e) => OpenChildForm(new ManageProjectForm{Owner = this});

        /// <summary>
        /// Open manage sub tasks form.
        /// </summary>
        private void ManageSubTasksButton_Click(object sender, EventArgs e) => OpenChildForm(new ManageSubTaskForm{Owner = this});

        /// <summary>
        /// Open settings form.
        /// </summary>
        private void SettingsButton_Click(object sender, EventArgs e) => OpenChildForm(new SettingsForm{Owner = this});

        /// <summary>
        /// Open manage user of task form.
        /// </summary>
        private void ManageUsersButton_Click(object sender, EventArgs e) => OpenChildForm(new ManageTaskUserForm{Owner = this});



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

        /// <summary>
        /// Set up visible of some button when painting this form.
        /// </summary>
        private void ManageTaskForm_Paint(object sender, PaintEventArgs e)
        {
            if (Manager.CurrentTask != null)
            {
                ManageSubTaskButton.Visible = Manager.CurrentTask is IManageable;
                ManageUsersButton.Visible = Manager.CurrentTask is IAssignable;
                PreviousButton.Visible = Manager.CurrentTask.TypeTask != TypeTask.Project;
                SettingsButton.Visible = true;
            }
            else
            {
                ManageSubTaskButton.Visible = false;
                ManageUsersButton.Visible = false;
                SettingsButton.Visible = false;
                PreviousButton.Visible = false;
            }
        }

        /// <summary>
        /// Change current task to current task's owner.
        /// </summary>
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            Manager.CurrentTask = Manager.CurrentTask.Owner;
            ActiveChildForm.Close();
            Invalidate();
        }
    }
}
