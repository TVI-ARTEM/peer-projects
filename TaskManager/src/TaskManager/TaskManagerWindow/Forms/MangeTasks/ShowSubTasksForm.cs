using System;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class ShowSubTasksForm : Form
    {
        /// <summary>
        /// Constrictor to create this object.
        /// </summary>
        public ShowSubTasksForm()
        {
            InitializeComponent();

            // Set some data and settings.
            ProjectsDataGridView.DataSource = (Manager.CurrentTask as IManageable)?.Tasks;

            ProjectsDataGridView.Columns["Owner"].Visible = false;

            ProjectsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProjectsDataGridView.MultiSelect = false;

        }

        /// <summary>
        /// Set selected task as current task.
        /// </summary>
        private void ChooseTaskButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var selectedRow = ProjectsDataGridView.SelectedRows[0];
                var task = (BaseTask)selectedRow.DataBoundItem;

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
        private void ShowSubTasksForm_Paint(object sender, PaintEventArgs e)
        {
            ChooseTaskButton.Enabled = (Manager.CurrentTask as IManageable)?.Tasks.Count > 0;
        }
    }
}
