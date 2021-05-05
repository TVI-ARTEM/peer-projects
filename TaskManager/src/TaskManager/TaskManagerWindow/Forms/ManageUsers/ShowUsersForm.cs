using System.Windows.Forms;

namespace TaskManagerWindow.Forms.ManageUsers
{
    public partial class ShowUsersForm : Form
    {
        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public ShowUsersForm()
        {
            InitializeComponent();
            // Set data.
            UsersDataGridView.DataSource = Manager.Users;
        }
    }
}
