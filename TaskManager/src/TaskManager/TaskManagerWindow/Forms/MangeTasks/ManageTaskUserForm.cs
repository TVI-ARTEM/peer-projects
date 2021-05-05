using System;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class ManageTaskUserForm : Form
    {
        /// <summary>
        /// Source data for dataGrid view.
        /// </summary>
        public BindingSource BindingSource = new();

        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public ManageTaskUserForm()
        {
            InitializeComponent();
            // Set some data and settings,
            BindingSource.DataSource = (Manager.CurrentTask as IAssignable)?.Users;

            TaskUserDataGridView.DataSource = BindingSource;
            TaskUserDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            UsersDataGridView.DataSource = Manager.Users;
            UsersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Remove user from current task.
        /// </summary>
        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) !=
                    DialogResult.Yes) return;

                // Remove all selected users.
                for (var index = 0; index < TaskUserDataGridView.SelectedRows.Count; index++)
                {
                    var selectedRow = TaskUserDataGridView.SelectedRows[index];
                    var user = (User) selectedRow.DataBoundItem;

                    (Manager.CurrentTask as IAssignable)?.RemoveUser(user);

                    BindingSource.ResetBindings(true);

                    RemoveUserButton.Enabled = (Manager.CurrentTask as IAssignable)?.Users.Count > 0;

                    Manager.SaveData();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add new user to current task.
        /// </summary>
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Add all selected users.
                for (var index = 0; index < UsersDataGridView.SelectedRows.Count; index++)
                {
                    var selectedRow = UsersDataGridView.SelectedRows[index];
                    var user = (User) selectedRow.DataBoundItem;

                    (Manager.CurrentTask as IAssignable)?.AddUser(user);

                    RemoveUserButton.Enabled = (Manager.CurrentTask as IAssignable)?.Users.Count > 0;

                    BindingSource.ResetBindings(true);

                    Manager.SaveData();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save data when closing.
        /// </summary>
        private void ManageTaskUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveData();
        }

        /// <summary>
        /// Set enabled of some buttons when painting this form. 
        /// </summary>
        private void ManageTaskUserForm_Paint(object sender, PaintEventArgs e)
        {
            AddUserButton.Enabled = Manager.Users.Count > 0;
            RemoveUserButton.Enabled = (Manager.CurrentTask as IAssignable)?.Users.Count > 0;
        }
    }
}