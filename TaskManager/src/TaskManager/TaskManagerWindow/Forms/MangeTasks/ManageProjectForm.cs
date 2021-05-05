using System;
using System.Windows.Forms;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class ManageProjectForm : Form
    {
        /// <summary>
        /// Opened child form.
        /// </summary>
        public Form ActiveChildForm { get; set; }

        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public ManageProjectForm()
        {
            InitializeComponent();
            OpenChildForm(new ShowProjectsFrom { Owner = this });
        }

        /// <summary>
        /// Open show projects form.
        /// </summary>
        private void ShowProjectButton_Click(object sender, EventArgs e) => OpenChildForm(new ShowProjectsFrom{Owner = this});

        /// <summary>
        /// Open create project form.
        /// </summary>
        private void CreateProjectButton_Click(object sender, EventArgs e) => OpenChildForm(new CreateProjectForm{Owner = this});

        /// <summary>
        /// Open remove project form.
        /// </summary>
        private void RemoveProjectButton_Click(object sender, EventArgs e) => OpenChildForm(new RemoveProjectForm {Owner = this});

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
