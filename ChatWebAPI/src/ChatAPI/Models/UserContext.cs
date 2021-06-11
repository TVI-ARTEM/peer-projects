using Microsoft.EntityFrameworkCore;

namespace ChatAPI.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Users database.
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}
