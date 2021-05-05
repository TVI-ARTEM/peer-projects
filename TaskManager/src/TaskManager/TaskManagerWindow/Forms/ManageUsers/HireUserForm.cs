using System;
using System.Linq;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.ManageUsers
{
    public partial class HireUserForm : Form
    {
        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public HireUserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hire new user.
        /// </summary>
        private void HireUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new User(UserNameTextBox.Text);

                // Check all list to compare with new user.
                if (Manager.Users.Any(us => us.Name.Equals(newUser.Name)))
                    throw new ArgumentException("This user has already been hired");

                Manager.Users.Add(newUser);
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save data when closing.
        /// </summary>
        private void HireUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveData();
        }
    }
}