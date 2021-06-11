using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatAPI.Repositories
{
    public class MailRepository : IMailRepository
    {
        /// <summary>
        /// Mail database.
        /// </summary>
        private readonly MailContext _context;

        public MailRepository(MailContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create mail.
        /// </summary>
        /// <param name="item">New mail.</param>
        /// <returns>Create item.</returns>
        public async Task<Mail> Create(Mail item)
        {
            await _context.Mails.AddAsync(item);
            await _context.SaveChangesAsync();

            return item;
        }

        /// <summary>
        /// Update mail's data.
        /// </summary>
        /// <param name="item">New data.</param>
        /// <returns>Nothing.</returns>
        public async Task Update(Mail item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete mail.
        /// </summary>
        /// <param name="item">Mail to delete.</param>
        /// <returns>Nothing.</returns>
        public async Task Delete(Mail item)
        {
            _context.Mails.Remove(item);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Get mails by sender and receiver id.
        /// </summary>
        /// <param name="senderId">Sender id.</param>
        /// <param name="receiverId">Receiver id.</param>
        /// <returns>Mails.</returns>
        public async Task<IEnumerable<Mail>> Get(string senderId, string receiverId)
        {
            return await _context.Mails
                .Where(mail => mail.SenderId.Equals(senderId) &&
                               mail.ReceiverId.Equals(receiverId))
                .ToListAsync();
        }

        /// <summary>
        /// Get mail by user id.
        /// </summary>
        /// <param name="userId">User id - email.</param>
        /// <returns>Mails.</returns>
        public async Task<IEnumerable<Mail>> Get(string userId)
        {
            return await _context.Mails
                .Where(mail => mail.SenderId.Equals(userId)
                               || mail.ReceiverId.Equals(userId))
                .ToListAsync();
        }

        /// <summary>
        /// Get sender's mails.
        /// </summary>
        /// <param name="senderId">Sender id - email.</param>
        /// <returns>Mails.</returns>
        public async Task<IEnumerable<Mail>> GetSenderMails(string senderId)
        {
            return await _context.Mails
                .Where(mail => mail.SenderId.Equals(senderId))
                .ToListAsync();
        }

        /// <summary>
        /// Get receiver's mails.
        /// </summary>
        /// <param name="receiverId">Receiver id - email.</param>
        /// <returns>Mails.</returns>
        public async Task<IEnumerable<Mail>> GetReceiverMails(string receiverId)
        {
            return await _context.Mails
                .Where(mail => mail.ReceiverId.Equals(receiverId))
                .ToListAsync();
        }

        /// <summary>
        /// Get mail by id.
        /// </summary>
        /// <param name="id">Mail id.</param>
        /// <returns>Mail.</returns>
        public async Task<Mail> Get(uint id)
        {
            return await _context.Mails.FindAsync(id);
        }
    }
}