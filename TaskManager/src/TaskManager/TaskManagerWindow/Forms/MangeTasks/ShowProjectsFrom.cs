using System;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class ShowProjectsFrom : Form
    {
        /// <summary>
        /// Constrictor to create this object.
        /// </summary>
        public ShowProjectsFrom()
        {
            InitializeComponent();

            // Set some data and settings.
            ProjectsDataGridView.DataSource = Manager.Projects;

            ProjectsDataGridView.MultiSelect = false;
            ProjectsDataGridView.Columns["MaxTasks"].Visible = false;
            ProjectsDataGridView.Columns["Owner"].Visible = false;

            ProjectsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Set selected project as current task.
        /// </summary>
        private void ChooseProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = ProjectsDataGridView.SelectedRows[0];
                var task = (BaseTask) selectedRow.DataBoundItem;

                Manager.CurrentTask = task;

                Owner.Owner.Invalidate();
                Owner.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set enabled of button when painting this form.
        /// </summary>
        private void ShowProjectsFrom_Paint(object sender, PaintEventArgs e)
        {
            ChooseProjectButton.Enabled = Manager.Projects.Count > 0;
        }
    }
}