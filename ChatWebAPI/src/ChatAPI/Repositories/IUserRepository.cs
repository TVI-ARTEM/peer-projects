using System.Collections.Generic;
using System.Threading.Tasks;
using ChatAPI.Models;

namespace ChatAPI.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Get all users.
        /// </summary>
        /// <returns>Users.</returns>
        Task<IEnumerable<User>> Get();
        /// <summary>
        /// Get user by id.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <returns>User.</returns>
        Task<User> Get(string userId);
        /// <summary>
        /// Get users.
        /// </summary>
        /// <param name="limit">Limit of users.</param>
        /// <param name="offset">Offset of users.</param>
        /// <returns>Users.</returns>
        Task<IEnumerable<User>> Get(int? limit, int? offset);
        /// <summary>
        /// Generate users.
        /// </summary>
        /// <param name="count">Count of users.</param>
        /// <returns>Task.</returns>
        Task Generate(int? count);
    }
}