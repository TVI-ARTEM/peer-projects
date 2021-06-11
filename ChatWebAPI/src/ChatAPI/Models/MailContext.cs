using Microsoft.EntityFrameworkCore;

namespace ChatAPI.Models
{
    public class MailContext : DbContext
    {
        public MailContext(DbContextOptions<MailContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Mail database.
        /// </summary>
        public DbSet<Mail> Mails { get; set; }
    }
}