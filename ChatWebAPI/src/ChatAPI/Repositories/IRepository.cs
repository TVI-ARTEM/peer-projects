using System.Threading.Tasks;

namespace ChatAPI.Repositories
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Create item.
        /// </summary>
        /// <param name="item">New item.</param>
        /// <returns>Item.</returns>
        Task<T> Create(T item);

        /// <summary>
        /// Update item.
        /// </summary>
        /// <param name="item">Item.</param>
        /// <returns>Task.</returns>
        Task Update(T item);

        /// <summary>
        /// Delete item.
        /// </summary>
        /// <param name="item">Item.</param>
        /// <returns>Task.</returns>
        Task Delete(T item);
    }
}