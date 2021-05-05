using System;
using System.Drawing;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Helpers;

namespace WareHouse.Forms
{
    public partial class CompanyCreatorForm : Form
    {
        public Company Company { get; }


        public CompanyCreatorForm()
        {
            Company = new Company();
            InitializeComponent();
            SetLocalization();
        }

        public CompanyCreatorForm(Company company) : this()
        {
            GetValues(company);
        }

        /// <summary>
        /// Set localized data.
        /// </summary>
        private void SetLocalization()
        {
            CompanyNameTextBox.PlaceholderText = ApplicationStrings.CompanyNamePlaceholder;
            CompanyNameTextBox.TextPlaceholder = ApplicationStrings.CompanyNamePlaceholder;

            CompanyAddressTextBox.PlaceholderText = ApplicationStrings.CompanyAddressPlaceholder;
            CompanyAddressTextBox.TextPlaceholder = ApplicationStrings.CompanyAddressPlaceholder;

            CompanyPhoneNumberTextBox.PlaceholderText = ApplicationStrings.CompanyPhoneNumberPlaceholder;
            CompanyPhoneNumberTextBox.TextPlaceholder = ApplicationStrings.CompanyPhoneNumberPlaceholder;

            CompanyChiefTextBox.PlaceholderText = ApplicationStrings.CompanyChiefPlaceholder;
            CompanyChiefTextBox.TextPlaceholder = ApplicationStrings.CompanyChiefPlaceholder;

            CompanyDescriptionTextBox.PlaceholderText = ApplicationStrings.CompanyDescriptionPlaceholder;
            CompanyDescriptionTextBox.TextPlaceholder = ApplicationStrings.CompanyDescriptionPlaceholder;

            ChangeImgButton.Text = ApplicationStrings.ChangeImgText;
        }

        /// <summary>
        /// Get values to controls from other company.
        /// </summary>
        /// <param name="company">Company.</param>
        private void GetValues(Company company)
        {
            try
            {
                CompanyNameTextBox.Text = company.Name;
                CompanyAddressTextBox.Text = company.Address;
                CompanyPhoneNumberTextBox.Text = company.PhoneNumber;
                CompanyChiefTextBox.Text = company.Chief;
                CompanyDescriptionTextBox.Text = company.Description;
                CompanyImage.Image = ImgConverter.ConvertStringToImg(company.Photo);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Change company image.
        /// </summary>
        private void ChangeImgButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openDialog = new OpenFileDialog
                {
                    Filter = ApplicationStrings.ImageFileDialogFilter
                })
                {
                    if (openDialog.ShowDialog() == DialogResult.OK)
                        CompanyImage.Image = Image.FromFile(openDialog.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set data from controls to company.
        /// </summary>
        private void SetValues()
        {
            Company.Name = CompanyNameTextBox.Text;
            Company.Address = CompanyAddressTextBox.Text;
            Company.PhoneNumber = CompanyPhoneNumberTextBox.Text;
            Company.Chief = CompanyChiefTextBox.Text;
            Company.Description = CompanyDescriptionTextBox.Text;
            Company.Photo = ImgConverter.ConvertImgToString((Bitmap) CompanyImage.Image);
        }

        /// <summary>
        /// Save data from controls to company.
        /// </summary>
        private void CompanyCreatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) return;

            try
            {
                SetValues();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}