using System.Collections.Generic;

namespace ProjectLibrary
{
    /// <summary>
    /// Interface for task, which have subTasks.
    /// </summary>
    public interface IManageable
    {
        /// <summary>
        /// List of subTasks.
        /// </summary>
        List<BaseTask> Tasks { get; set; }

        /// <summary>
        /// Limit of number of subTasks.
        /// </summary>
        uint MaxTasks { get; set; }
        /// <summary>
        /// Add new task to list.
        /// </summary>
        /// <param name="task">New task.</param>
        void AddTask(BaseTask task);
        /// <summary>
        /// Remove certain task.
        /// </summary>
        /// <param name="task">Certain task.</param>
        void RemoveTask(BaseTask task);

        /// <summary>
        /// Get info about all tasks.
        /// </summary>
        /// <returns>SubTasks info</returns>
        string GetTasksInfo();
    }
}