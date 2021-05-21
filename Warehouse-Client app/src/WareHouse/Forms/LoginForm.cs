using System;
using System.Configuration;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Enums;
using WareHouse.Managers;
using WareHouse.Properties;
using Application = System.Windows.Forms.Application;

namespace WareHouse.Forms
{
    public partial class LoginForm : Form
    {
        #region Fields

        /// <summary>
        /// Show password.
        /// </summary>
        private bool _isShow;

        /// <summary>
        /// User login type.
        /// </summary>
        private Login _login;

        #endregion

        public LoginForm()
        {
            InitializeComponent();
            FormDock.SubscribeControlsToDragEvents(new Control[] {MainPanel, LogoBox, ErrorPanel});
        }

        #region Form manage

        /// <summary>
        /// Set data and localization.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                _login = Login.User;
                _isShow = false;
                PasswordTextBox.UseSystemPasswordChar = true;
                PasswordTextBox.IconRight = Resources.Show_password;

                // Get clients data.
                Manager.LoadClient();

                SetLocalization();
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Set localization.
        /// </summary>
        private void SetLocalization()
        {
            LoginButton.Text = ApplicationStrings.LoginButtonText;
            ForgotPasswordThinButton.ButtonText = ApplicationStrings.ForgotPasswordThinButtonText;
            SignUpThinButton.ButtonText = ApplicationStrings.SignUpThinButtonText;

            ToolTip.SetToolTip(UserButton, ApplicationStrings.UserButtonToolTip);
            ToolTip.SetToolTipTitle(UserButton, ApplicationStrings.UserButtonToolTipTitle);
          
            ToolTip.SetToolTip(WorkerButton, ApplicationStrings.WorkerButtonToolTip);
            ToolTip.SetToolTipTitle(WorkerButton, ApplicationStrings.WorkerButtonToolTipTitle);
        }

        /// <summary>
        /// Save data.
        /// </summary>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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
            try
            {
                Save("login", "exit");
                ErrorTextBox.Visible = false;
                Close();
            }
            catch (Exception exception)
            {
                ErrorTextBox.Visible = true;
                ErrorTextBox.Text = exception.Message;
            }
        }


        /// <summary>
        /// Set english language.
        /// </summary>
        private void EngButton_Click(object sender, EventArgs e)
        {
            // Set english language.
            Save("culture", "en-US");
            Application.Restart();
        }

        /// <summary>
        /// Set russian language.
        /// </summary>
        private void RusButton_Click(object sender, EventArgs e)
        {
            // Set russian language.
            Save("culture", "ru-RU");
            Application.Restart();
        }


        /// <summary>
        /// Save action settings.
        /// </summary>
        /// <param name="key">Key in config.</param>
        /// <param name="value">New value.</param>
        private static void Save(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            if (settings[key] != null)
                settings.Remove(key);
            settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        #endregion

        #region Controls manage

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
        /// Change user login type to user.
        /// </summary>
        private void UserButton_Click(object sender, EventArgs e)
        {
            _login = Login.User;
        }

        /// <summary>
        /// Change user login type to worker.
        /// </summary>
        private void WorkerButton_Click(object sender, EventArgs e)
        {
            _login = Login.Worker;
        }


        /// <summary>
        /// Sign in to app.
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Manager.CurrentClient = ClientManager.GetByPassword(UserNameTextBox.Text, PasswordTextBox.Text, _login);
                Save("login", _login == Login.Worker ? "worker" : "user");
                ErrorTextBox.Visible = false;
                Close();
            }
            catch (Exception exception)
            {
                ErrorTextBox.Visible = true;
                ErrorTextBox.Text = exception.Message;
            }
        }

        /// <summary>
        /// Restore password.
        /// </summary>
        private void ForgotPasswordThinButton_Click(object sender, EventArgs e)
        {
            try
            {
                Opacity = 0;
                using (var restorePassword = new RestoreForm())
                {
                    restorePassword.ShowDialog();
                }

                ErrorTextBox.Visible = false;
            }
            catch (Exception exception)
            {
                ErrorTextBox.Visible = true;
                ErrorTextBox.Text = exception.Message;
            }
            finally
            {
                Opacity = 1;
            }
        }

        /// <summary>
        /// Create new client account.
        /// </summary>
        private void SignUpThinButton_Click(object sender, EventArgs e)
        {
            try
            {
                Opacity = 0;
                using (var signUp = new ClientCreatorForm())
                {
                    signUp.ShowDialog();
                }

                ErrorTextBox.Visible = false;
            }
            catch (Exception exception)
            {
                ErrorTextBox.Visible = true;
                ErrorTextBox.Text = exception.Message;
            }
            finally
            {
                Opacity = 1;
            }
        }

        #endregion
    }
}