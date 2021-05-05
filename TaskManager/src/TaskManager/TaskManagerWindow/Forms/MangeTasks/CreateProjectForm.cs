using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class CreateProjectForm : Form
    {
        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public CreateProjectForm()
        {
            InitializeComponent();
            // Set data.
            StateComboBox.DataSource = new List<State>
            {
                State.Open,
                State.InProgress,
                State.Closed
            };
            StateComboBox.SelectedIndex = 0;

        }

        /// <summary>
        /// Create new project.
        /// </summary>
        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newProject = new Project(ProjectNameTextBox.Text)
                {
                    MaxTasks = uint.Parse(MaxTaskTextBox.Text),
                    State = (State) StateComboBox.SelectedItem
                };


                Manager.Projects.Add(newProject);
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
        private void CreateProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveData();
            Manager.SortTasks();
        }
    }
}
