using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLibrary
{
    [Serializable]
    public class Story : BaseTask, IAssignable, IManageable
    {
        /// <summary>
        /// This task users.
        /// </summary>
        public List<User> Users { get; set; }
        /// <summary>
        /// List of subTasks of current task.
        /// </summary>
        public List<BaseTask> Tasks { get; set; }
        /// <summary>
        /// Limit of number of subTasks.
        /// </summary>
        public uint MaxTasks { get; set; }
        /// <summary>
        /// Current number of tasks.
        /// </summary>
        public int TaskCount => Tasks.Count;
        /// <summary>
        /// Constructor only for json.
        /// </summary>
        public Story()
        {
            Users = new List<User>();
            Tasks = new List<BaseTask>();
        }
        /// <summary>
        /// Task constructor.
        /// </summary>
        /// <param name="name">Task name.</param>
        public Story(string name) : base(name, TypeTask.Story)
        {
            Users = new List<User>();
            Tasks = new List<BaseTask>();
        }

        /// <summary>
        /// Add new user to list.
        /// </summary>
        /// <param name="user">New user.</param>
        public void AddUser(User user)
        {
            // Check if there is already certain user.
            if (Users.Any(us => us.Name.Equals(user.Name))) throw new ArgumentException("This user has already been added");

            Users.Add(user);
        }

        /// <summary>
        /// Remove user from list.
        /// </summary>
        /// <param name="user">Certain user.</param>
        public void RemoveUser(User user)
        {
            Users.Remove(user);
        }

        /// <summary>
        /// Add new task to certain task.
        /// </summary>
        /// <param name="task">New task.</param>
        public void AddTask(BaseTask task)
        {
            // Check type task and current number of task count.

            if (task.TypeTask != TypeTask.Task)
            {
                throw new ArgumentException("Incorrect task type, only \"Task\".");
            }

            if (TaskCount  == MaxTasks)
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
        /// Get info about all subTasks.
        /// </summary>
        /// <returns>SubTasks info.</returns>
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
        /// Change current state and all subTasks state.
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
            return $"Name: {Name}; Creation Date: {CreationDateTime}; State: {State}; " +
                   $"Type: {TypeTask}; Users count: {Users.Count}; Tasks count: {TaskCount}";
        }
    }
}