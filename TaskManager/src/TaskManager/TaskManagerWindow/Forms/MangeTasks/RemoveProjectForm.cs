using System;
using System.Linq;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class RemoveProjectForm : Form
    {
        /// <summary>
        /// Source data for dataGrid view.
        /// </summary>
        public BindingSource BindingSource = new();

        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public RemoveProjectForm()
        {
            InitializeComponent();
            // Set some data and settings.
            BindingSource.DataSource = Manager.Projects;
            ProjectsDataGridView.DataSource = BindingSource;

            ProjectsDataGridView.Columns["MaxTasks"].Visible = false;
            ProjectsDataGridView.Columns["Owner"].Visible = false;
            ProjectsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        /// <summary>
        /// Remove project from data.
        /// </summary>
        private void RemoveProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) !=
                    DialogResult.Yes) return;

                // Remove all selected projects.
                for (var index = 0; index < ProjectsDataGridView.SelectedRows.Count; index++)
                {
                    var selectedRow = ProjectsDataGridView.SelectedRows[index];
                    var project = (Project) selectedRow.DataBoundItem;

                    Manager.Projects.Remove(project);

                    CheckCurrentTask(project);

                    Owner.Owner.Invalidate();

                    BindingSource.ResetBindings(true);
                }

                RemoveProjectButton.Enabled = Manager.Projects.Count > 0;

                Manager.SaveData();

                Owner.Owner.Invalidate();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Check if project has current task.
        /// </summary>
        /// <param name="checkTask">Checking task.</param>
        /// <returns>If there is current task.</returns>
        private static bool CheckCurrentTask(BaseTask checkTask)
        {
            if (!checkTask.Equals(Manager.CurrentTask))
                return checkTask is IManageable manageable && (manageable?.Tasks).Any(CheckCurrentTask);

            Manager.CurrentTask = null;
            return true;
        }

        /// <summary>
        /// Save data when closing.
        /// </summary>
        private void RemoveProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveData();
            Manager.SortTasks();

        }

        /// <summary>
        /// Set enabled for button when painting this form.
        /// </summary>
        private void RemoveProjectForm_Paint(object sender, PaintEventArgs e)
        {
            RemoveProjectButton.Enabled = Manager.Projects.Count > 0;
        }
    }
}