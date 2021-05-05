using System.Collections.Generic;

namespace ProjectLibrary
{
    /// <summary>
    /// Interface for task, which have users.
    /// </summary>
    public interface IAssignable
    {
        /// <summary>
        /// List of users.
        /// </summary>
        List<User> Users { get; set; }

        /// <summary>
        /// Add new user to list.
        /// </summary>
        /// <param name="user">New user.</param>
        void AddUser(User user);

        /// <summary>
        /// Remove certain user.
        /// </summary>
        /// <param name="user">Certain user.</param>
        void RemoveUser(User user);
    }
}