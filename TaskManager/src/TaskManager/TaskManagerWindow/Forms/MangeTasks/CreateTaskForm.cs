using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerWindow.Forms.MangeTasks
{
    public partial class CreateTaskForm : Form
    {
        /// <summary>
        /// Constructor to create this object.
        /// </summary>
        public CreateTaskForm()
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

            TypeTaskComboBox.DataSource = new List<TypeTask>
            {
                TypeTask.Epic,
                TypeTask.Story,
                TypeTask.Task,
                TypeTask.Bug
            };
            TypeTaskComboBox.SelectedIndex = 0;
        }


        /// <summary>
        /// Create new task.
        /// </summary>
        private void CreateTaskButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                BaseTask newTask = null;

                // Create task by user choice.
                switch ((TypeTask)TypeTaskComboBox.SelectedItem)
                {
                    case TypeTask.Epic:
                        newTask = new Epic(TaskNameTextBox.Text)
                        {
                            State = (State) StateComboBox.SelectedItem,
                            MaxTasks = uint.Parse(MaxTaskTextBox.Text)
                        };
                        break;
                    case TypeTask.Story:
                        newTask = new Story(TaskNameTextBox.Text)
                        {
                            State = (State)StateComboBox.SelectedItem,
                            MaxTasks = uint.Parse(MaxTaskTextBox.Text)
                        };
                        break;
                    case TypeTask.Task:
                        newTask = new Task(TaskNameTextBox.Text)
                        {
                            State = (State)StateComboBox.SelectedItem,
                        };
                        break;
                    case TypeTask.Bug:
                        newTask = new Bug(TaskNameTextBox.Text)
                        {
                            State = (State)StateComboBox.SelectedItem,
                        };
                        break;
                }

                (Manager.CurrentTask as IManageable)?.AddTask(newTask);

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
        private void CreateTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveData();
            Manager.SortTasks();

        }

        /// <summary>
        /// Change button and label visible when type task is changed.
        /// </summary>
        private void TypeTaskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((TypeTask)TypeTaskComboBox.SelectedItem)
            {
                case TypeTask.Epic:
                case TypeTask.Story:
                    MaxTaskTextBox.Visible = true;
                    MaxTaskLabel.Visible = true;
                    break;
                case TypeTask.Task:
                case TypeTask.Bug:
                    MaxTaskTextBox.Visible = false;
                    MaxTaskLabel.Visible = false;
                    break;
            }
        }
    }
}