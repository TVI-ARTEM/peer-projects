using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Entities;

namespace WareHouse.Forms
{
    public partial class RootCreatorForm : Form
    {
        /// <summary>
        /// Section.
        /// </summary>
        public Section Section;

        public RootCreatorForm()
        {
            InitializeComponent();
            SetLocalization();
            Section = new Section("newRoot");
        }

        public RootCreatorForm(List<string> path) : this()
        {
            Section.Path.InsertRange(0, path);
        }

        public RootCreatorForm(Section section) : this()
        {
            RootNameTextBox.Text = section.Name;
        }

        /// <summary>
        /// Set localized data.
        /// </summary>
        private void SetLocalization()
        {
            RootNameTextBox.PlaceholderText = ApplicationStrings.RootNamePlaceholder;
            RootNameTextBox.TextPlaceholder = ApplicationStrings.RootNamePlaceholder;
        }

        /// <summary>
        /// Set values from controls.
        /// </summary>
        private void RootCreatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) return;

            try
            {
                Section.Name = RootNameTextBox.Text;
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