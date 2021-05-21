using System;
using System.Windows.Forms;
using WareHouse.Entities;
using WareHouse.Managers;
using WareHouse.Properties;

namespace WareHouse.Forms
{
    public partial class RestoreForm : Form
    {
        #region Fields

        /// <summary>
        /// Show password.
        /// </summary>
        private bool _isShow;

        /// <summary>
        /// Client to restore password.
        /// </summary>
        private Client _restoreClient;

        #endregion

        public RestoreForm()
        {
            InitializeComponent();
            FormDock.SubscribeControlsToDragEvents(new Control[] {MainPanel, ErrorPanel});
        }

        #region Form manage

        /// <summary>
        /// Set data and settings.
        /// </summary>
        private void RestoreForm_Load(object sender, EventArgs e)
        {
            PasswordLabel.Visible = false;
            PasswordTextBox.Visible = false;
            SavePasswordButton.Visible = false;

            _isShow = false;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.IconRight = Resources.Show_password;
        }

        /// <summary>
        /// Save data.
        /// </summary>
        private void RestoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Manager.SaveClient();
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Close form.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Show or hide password.
        /// </summary>
        private void PasswordTextBox_OnIconRightClick(object sender, EventArgs e)
        {
            ShowPassword();
        }

        /// <summary>
        /// Show or hide password - internal method.
        /// </summary>
        private void ShowPassword()
        {
            if (_isShow)
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                _isShow = false;
                PasswordTextBox.IconRight = Resources.Show_password;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                _isShow = true;
                PasswordTextBox.IconRight = Resources.Hide_password;
            }
        }


        /// <summary>
        /// Get restored client.
        /// </summary>
        private void RestoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                _restoreClient = ClientManager.GetByName(UserNameTextBox.Text);
                UserNameTextBox.Enabled = false;
                RestoreButton.Enabled = false;
                PasswordLabel.Visible = true;
                PasswordTextBox.Visible = true;
                SavePasswordButton.Visible = true;
                ErrorTextBox.Visible = false;
            }
            catch (Exception exception)
            {
                ErrorTextBox.Visible = true;
                ErrorTextBox.Text = exception.Message;
            }
        }

        /// <summary>
        /// Save new password.
        /// </summary>
        private void SavePasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                _restoreClient.Password = PasswordTextBox.Text;
                ErrorTextBox.Visible = false;
                Close();
            }
            catch (Exception exception)
            {
                ErrorTextBox.Visible = true;
                ErrorTextBox.Text = exception.Message;
            }
        }

        #endregion
    }
}