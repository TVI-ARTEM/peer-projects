using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Users database.
        /// </summary>
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all users.
        /// </summary>
        /// <returns>Users.</returns>
        public async Task<IEnumerable<User>> Get()
        {
            return await _context.Users.ToListAsync();
        }

        /// <summary>
        /// Create new user and added it to database.
        /// </summary>
        /// <param name="item">New user.</param>
        /// <returns>Created user.</returns>
        public async Task<User> Create(User item)
        {
            await _context.Users.AddAsync(item);
            await _context.SaveChangesAsync();

            return item;
        }

        /// <summary>
        /// Update user's data.
        /// </summary>
        /// <param name="item">User to update.</param>
        /// <returns>Nothing.</returns>
        public async Task Update(User item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Get user by id.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <returns>User.</returns>
        public async Task<User> Get(string userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        /// <summary>
        /// Get users.
        /// </summary>
        /// <param name="limit">Limit of users.</param>
        /// <param name="offset">Offset of users.</param>
        /// <returns>Users.</returns>
        public async Task<IEnumerable<User>> Get(int? limit, int? offset)
        {
            var limitCount = limit ?? _context.Users.Count();
            var offsetCount = offset ?? 0;
            return await _context.Users.Skip(offsetCount).Take(limitCount).ToListAsync();
        }

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="item">User to delete.</param>
        /// <returns>Nothing.</returns>
        public async Task Delete(User item)
        {
            _context.Users.Remove(item);
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// Generate new users.
        /// </summary>
        /// <param name="count">Count of users.</param>
        /// <returns>Nothing.</returns>
        public async Task Generate(int? count)
        {
            var random = new Random();
            var userCount = count ?? random.Next(4, 11);

            foreach (var entity in _context.Users)
                _context.Users.Remove(entity);
            await _context.SaveChangesAsync();

            foreach (var user in User.GenerateUsers(userCount))
            {
                await _context.Users.AddAsync(user);
            }

            await _context.SaveChangesAsync();
        }
    }
}