using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Managers;

namespace WareHouse.Forms
{
    public partial class SaveLoadForm : Form
    {
        /// <summary>
        /// Warehouses names.
        /// </summary>
        private List<string> _foldersName;
        /// <summary>
        /// Warehouse to load.
        /// </summary>
        public string LoadFolder;
        /// <summary>
        /// Need to load data.
        /// </summary>
        public bool IsLoad;

        public SaveLoadForm()
        {
            InitializeComponent();
            _foldersName = new List<string>();
            IsLoad = false;
        }

        /// <summary>
        /// Set data.
        /// </summary>
        private void SaveLoadForm_Load(object sender, EventArgs e)
        {
            try
            {
                _foldersName = Directory.GetDirectories(Path.Combine(Manager.AppPath)).ToList();
                foreach (var folder in _foldersName)
                {
                    FolderListBox.Items.Add(folder.Split('\\')[1]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save data.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_foldersName.Any(folder =>
                    folder.Split('\\')[1].Equals(FolderNameTextBox.Text, StringComparison.InvariantCultureIgnoreCase)))
                {
                    if (MessageBox.Show(ApplicationStrings.WarehouseExistWarning, ApplicationStrings.MessageWarning,
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                    {
                        return;
                    }
                }

                Manager.Save(FolderNameTextBox.Text);
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set folder name to load data.
        /// </summary>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadFolder = FolderListBox.SelectedItem.ToString();
                IsLoad = true;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}