using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectLibrary
{
    [Serializable]
    public class Bug : BaseTask, IAssignable
    {
        /// <summary>
        /// This task users.
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// Constructor only for json.
        /// </summary>
        public Bug()
        {
            Users = new List<User>();
        }

        /// <summary>
        /// Task constructor.
        /// </summary>
        /// <param name="name">Task name.</param>
        public Bug(string name) : base(name, TypeTask.Bug)
        {
            Users = new List<User>();
        }

        /// <summary>
        /// Add new user to list.
        /// </summary>
        /// <param name="user">New user.</param>
        public void AddUser(User user)
        {
            // Check Users count.
            if (Users.Count == 1)
            {
                throw new ArgumentOutOfRangeException("A task can have only one user", new Exception());
            }

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
        /// Get task by index.
        /// </summary>
        /// <param name="index">Task index.</param>
        /// <returns>Certain task.</returns>
        public override BaseTask GetTask(int index)
        {
            throw new InvalidOperationException("The \"Bug\" task has no subtasks!");
        }

        /// <summary>
        /// Get task info.
        /// </summary>
        /// <returns>Task info.</returns>
        public override string ToString()
        {
            return $"Name: {Name}; Creation Date: {CreationDateTime}; " +
                   $"State: {State}; Type: {TypeTask}; Users count: {Users.Count}";
        }
    }
}
