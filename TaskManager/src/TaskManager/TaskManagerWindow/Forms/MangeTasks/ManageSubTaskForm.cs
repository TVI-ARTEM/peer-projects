using System;
using System.Windows.Forms;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class ManageSubTaskForm : Form
    {
        /// <summary>
        /// Opened child form.
        /// </summary>
        public Form ActiveChildForm { get; set; }

        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public ManageSubTaskForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open show subTasks form.
        /// </summary>
        private void ShowTaskButton_Click(object sender, EventArgs e) => OpenChildForm(new ShowSubTasksForm{Owner = this});

        /// <summary>
        /// Open create new task form.
        /// </summary>
        private void CreateTaskButton_Click(object sender, EventArgs e) => OpenChildForm(new CreateTaskForm { Owner = this });

        /// <summary>
        /// Open remove tasks form.
        /// </summary>
        private void RemoveTaskButton_Click(object sender, EventArgs e) => OpenChildForm(new RemoveTaskForm { Owner = this });


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
