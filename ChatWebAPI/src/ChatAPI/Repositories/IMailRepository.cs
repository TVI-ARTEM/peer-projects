using System.Collections.Generic;
using System.Threading.Tasks;
using ChatAPI.Models;

namespace ChatAPI.Repositories
{
    public interface IMailRepository : IRepository<Mail>
    {
        /// <summary>
        /// Get mails.
        /// </summary>
        /// <param name="senderId">Sender id.</param>
        /// <param name="receiverId">Receiver id.</param>
        /// <returns>Mails.</returns>
        Task<IEnumerable<Mail>> Get(string senderId, string receiverId);

        /// <summary>
        /// Get mails.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <returns>Mails.</returns>
        Task<IEnumerable<Mail>> Get(string userId);

        /// <summary>
        /// Get sender's mails.
        /// </summary>
        /// <param name="senderId">Sender id.</param>
        /// <returns>Mails.</returns>
        Task<IEnumerable<Mail>> GetSenderMails(string senderId);

        /// <summary>
        /// Get receiver's mails.
        /// </summary>
        /// <param name="receiverId">Receiver id.</param>
        /// <returns>Mails.</returns>
        Task<IEnumerable<Mail>> GetReceiverMails(string receiverId);

        /// <summary>
        /// Get mail bu id.
        /// </summary>
        /// <param name="id">Mail id.</param>
        /// <returns>Mail.</returns>
        Task<Mail> Get(uint id);
    }
}