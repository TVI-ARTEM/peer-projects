using System;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Enums;
using WareHouse.Managers;
using WareHouse.Properties;

namespace WareHouse.Forms
{
    public partial class ClientCreatorForm : Form
    {
        private bool _isShow;

        public ClientCreatorForm()
        {
            InitializeComponent();
            FormDock.SubscribeControlsToDragEvents(new Control[] {MainPanel, SignUpLabel, ErrorPanel});
        }

        private void PasswordTextBox_OnIconRightClick(object sender, EventArgs e)
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

        private void ClientCreatorForm_Load(object sender, EventArgs e)
        {
            try
            {
                _isShow = false;
                PasswordTextBox.UseSystemPasswordChar = true;
                PasswordTextBox.IconRight = Resources.Show_password;
                CityDropdown.DataSource = City.GetNames();
                CityDropdown.SelectedIndex = (int) City.Moscow;

                PasswordTextBox.TextPlaceholder = ApplicationStrings.PasswordTextBoxTextPlaceholder;
                PasswordTextBox.PlaceholderText = ApplicationStrings.PasswordTextBoxTextPlaceholder;

                FirstNameTextBox.TextPlaceholder = ApplicationStrings.FirstNameTextBoxTextPlaceholder;
                FirstNameTextBox.PlaceholderText = ApplicationStrings.FirstNameTextBoxTextPlaceholder;

                PatronymicTextBox.TextPlaceholder = ApplicationStrings.PatronymicTextBoxTextPlaceholder;
                PatronymicTextBox.PlaceholderText = ApplicationStrings.PatronymicTextBoxTextPlaceholder;

                LastNameTextBox.TextPlaceholder = ApplicationStrings.LastNameTextBoxTextPlaceholder;
                LastNameTextBox.PlaceholderText = ApplicationStrings.LastNameTextBoxTextPlaceholder;

                PhoneNumberTextBox.TextPlaceholder = ApplicationStrings.PhoneNumberTextBoxTextPlaceholder;
                PhoneNumberTextBox.PlaceholderText = ApplicationStrings.PhoneNumberTextBoxTextPlaceholder;
            }
            catch
            {
                // ignored
            }
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) | e.KeyChar.Equals('(') | e.KeyChar.Equals(')') |
                e.KeyChar.Equals('-') | e.KeyChar.Equals('+') | char.IsControl(e.KeyChar)) return;

            e.Handled = true;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newClient = new Client
                {
                    Email = EmailTextBox.Text,
                    Login = LoginTextBox.Text,
                    Password = PasswordTextBox.Text,

                    FirstName = FirstNameTextBox.Text,
                    Patronymic = PatronymicTextBox.Text,
                    LastName = LastNameTextBox.Text,

                    PhoneNumber = PhoneNumberTextBox.Text,
                    ClientCityId = City.GetById(CityDropdown.SelectedIndex).Values.Item1,
                    LoginType = WorkerToggleSwitch.Checked ? Login.Worker : Login.User
                };

                ClientManager.Add(newClient);
                ErrorTextBox.Visible = false;
                Close();
            }
            catch (Exception exception)
            {
                ErrorTextBox.Visible = true;
                ErrorTextBox.Text = exception.Message;
            }
        }

        private void ClientCreatorForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}