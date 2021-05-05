using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLibrary
{
    [Serializable]
    public class Epic : BaseTask, IManageable
    {
        /// <summary>
        /// List of subTask of certain task.
        /// </summary>
        public List<BaseTask> Tasks { get; set; }
        /// <summary>
        /// Limit of subTasks quantity.
        /// </summary>
        public uint MaxTasks { get; set; }
        /// <summary>
        /// Current number of subTasks.
        /// </summary>
        public int TasksCount => Tasks.Count;

        /// <summary>
        /// Constructor only for json.
        /// </summary>
        public Epic()
        {
            Tasks = new List<BaseTask>();

        }

        /// <summary>
        /// Task constructor.
        /// </summary>
        /// <param name="name"></param>
        public Epic(string name) : base(name, TypeTask.Epic)
        {
            Tasks = new List<BaseTask>();
        }


        /// <summary>
        /// Add new task.
        /// </summary>
        /// <param name="task">New task.</param>
        public void AddTask(BaseTask task)
        {
            // Check task type and current number of subTasks.
            if (task.TypeTask != TypeTask.Story && task.TypeTask != TypeTask.Task)
            {
                throw new ArgumentException("Incorrect task type, only \"Story\" and \"Task\".");
            }
            if (TasksCount == MaxTasks)
            {
                throw new Exception($"Can't add more than {MaxTasks} tasks.");
            }

            task.Owner = this;

            Tasks.Add(task);

        }

        /// <summary>
        /// Remove certain task.
        /// </summary>
        /// <param name="task">Certain task.</param>
        public void RemoveTask(BaseTask task)
        {
            Tasks.Remove(task);
        }

        /// <summary>
        /// Get info about all SubTasks.
        /// </summary>
        /// <returns></returns>
        public string GetTasksInfo()
        {
            return Tasks.Aggregate(string.Empty, (current, task) => current + (task + Environment.NewLine));
        }


        /// <summary>
        /// Get task by index.
        /// </summary>
        /// <param name="index">Task index.</param>
        /// <returns>Certain task.</returns>
        public override BaseTask GetTask(int index)
        {
            try
            {
                return Tasks[index];

            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("User not found");
            }
        }

        /// <summary>
        /// Change current task state and all subTasks.
        /// </summary>
        /// <param name="state">New state.</param>
        public override void ChangeState(State state)
        {
            base.ChangeState(state);

            if (!state.Equals(State.Closed)) return;
            
            foreach (var task in Tasks)
            {
                task.ChangeState(state);
            }
        }

        /// <summary>
        /// Get task info.
        /// </summary>
        /// <returns>Task info.</returns>
        public override string ToString()
        {
            return $"Name: {Name}; Creation Date: {CreationDateTime}; " +
                   $"State: {State}; Type: {TypeTask}; Tasks count: {TasksCount}";
        }
    }
}
