using System;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class RemoveTaskForm : Form
    {
        /// <summary>
        /// Source data for dataGrid view.
        /// </summary>
        public BindingSource BindingSource = new();

        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public RemoveTaskForm()
        {
            InitializeComponent();
            // Set some data and settings.
            BindingSource.DataSource = (Manager.CurrentTask as IManageable)?.Tasks;
            TasksDataGridView.DataSource = BindingSource;

            TasksDataGridView.Columns["Owner"].Visible = false;
            TasksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Remove task from data.
        /// </summary>
        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) !=
                    DialogResult.Yes) return;

                // Remove all selected projects.
                for (var index = 0; index < TasksDataGridView.SelectedRows.Count; index++)
                {
                    var selectedRow = TasksDataGridView.SelectedRows[index];
                    var task = (BaseTask) selectedRow.DataBoundItem;

                    (Manager.CurrentTask as IManageable)?.RemoveTask(task);

                    BindingSource.ResetBindings(true);
                }

                RemoveTaskButton.Enabled = (Manager.CurrentTask as IManageable)?.Tasks.Count > 0;


                Owner.Owner.Invalidate();
                Owner.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save data when closing.
        /// </summary>
        private void RemoveTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveData();
            Manager.SortTasks();

        }

        /// <summary>
        /// Set enabled for button when painting this form.
        /// </summary>
        private void RemoveTaskForm_Paint(object sender, PaintEventArgs e)
        {
            RemoveTaskButton.Enabled = (Manager.CurrentTask as IManageable)?.Tasks.Count > 0;
        }
    }
}