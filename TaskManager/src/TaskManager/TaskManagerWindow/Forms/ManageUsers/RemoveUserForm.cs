using System;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.ManageUsers
{
    public partial class RemoveUserForm : Form
    {
        /// <summary>
        /// Source data for dataGrid view.
        /// </summary>
        public BindingSource BindingSource = new();

        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public RemoveUserForm()
        {
            InitializeComponent();
            // Set up some settings and data.
            BindingSource.DataSource = Manager.Users;
            UsersDataGridView.DataSource = BindingSource;
            UsersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        /// <summary>
        /// Fire selected users.
        /// </summary>
        private void FireUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) !=
                    DialogResult.Yes) return;

                // Remove selected objects. 
                for (var index = 0; index < UsersDataGridView.SelectedRows.Count; index++)
                {
                    var selectedRow = UsersDataGridView.SelectedRows[index];
                    var user = (User)selectedRow.DataBoundItem;

                    foreach (var project in Manager.Projects)
                    {
                        RemoveUserFromTask(project, user);
                    }

                    Manager.Users.Remove(user);

                    FireUserButton.Enabled = Manager.Users.Count > 0;


                    // Refresh data.
                    BindingSource.ResetBindings(true);

                }

                Manager.SaveData();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove user from all task.
        /// </summary>
        /// <param name="task">Checking task.</param>
        /// <param name="user">Removing user.</param>
        private static void RemoveUserFromTask(BaseTask task, User user)
        {
            (task as IAssignable)?.RemoveUser(user);

            var subTasks = (task as IManageable)?.Tasks;
            if (subTasks == null) return;
            foreach (var subTask in subTasks)
            {
                RemoveUserFromTask(subTask, user);
            }
        }


        /// <summary>
        /// Save data when closing.
        /// </summary>
        private void RemoveUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveData();
        }

        /// <summary>
        /// Set button enabled when painting form.
        /// </summary>
        private void RemoveUserForm_Paint(object sender, PaintEventArgs e)
        {
            FireUserButton.Enabled = Manager.Users.Count > 0;
        }
    }
}