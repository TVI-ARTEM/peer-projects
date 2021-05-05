using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// Constrictor to create this object.
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();
            // Set some data and settings.
            StateComboBox.DataSource = new List<State>
            {
                State.Open,
                State.InProgress,
                State.Closed
            };

            TaskLabel.Text = $"Task: {Manager.CurrentTask.Name}";
            StateComboBox.SelectedItem = Manager.CurrentTask.State;
            TaskNameTextBox.Text = Manager.CurrentTask.Name;
        }

        /// <summary>
        /// Change some settings of current task.
        /// </summary>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                Manager.CurrentTask.Name = TaskNameTextBox.Text;
                Manager.CurrentTask.State = (State) StateComboBox.SelectedItem;

                Manager.SaveData();

                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save data when closing form.
        /// </summary>
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveData();
            Manager.SortTasks();
        }
    }
}
