using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatAPI.Models;
using ChatAPI.Repositories;

namespace ChatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        /// <summary>
        /// Mail database.
        /// </summary>
        private readonly IMailRepository _mailRepository;

        /// <summary>
        /// User database.
        /// </summary>
        private readonly IUserRepository _userRepository;


        public MailController(IMailRepository mailRepository, IUserRepository userRepository)
        {
            _mailRepository = mailRepository;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Get mails by sender and receiver id.
        /// </summary>
        /// <remarks>
        /// Request:
        /// /api/Mail/GetMails?senderId=address1%40mail.ru&amp;receiverId=address2%40mail.ru
        /// 
        /// Response:
        /// [
        /// {
        ///    "id": 3437030222,
        ///    "subject": "Hi!",
        ///    "message": "Hello",
        ///    "senderId": "address1@mail.ru",
        ///    "receiverId": "address2@mail.ru"
        /// }
        /// ]
        /// </remarks>
        /// <response code="200">Sender and receiver mails.</response>
        /// <response code="404">Sender or receiver are not found.</response>
        /// <param name="senderId">Sender id.</param>
        /// <param name="receiverId">Receiver id.</param>
        /// <returns>Mails.</returns>
        [HttpGet("GetMails")]
        public async Task<ActionResult<IEnumerable<Mail>>> GetMails(string senderId, string receiverId)
        {
            var sender = await _userRepository.Get(senderId);
            var receiver = await _userRepository.Get(receiverId);

            if (sender == null || receiver == null)
            {
                return NotFound("Sender or receiver are not found");
            }

            return new ActionResult<IEnumerable<Mail>>(await _mailRepository.Get(senderId, receiverId));
        }

        /// <summary>
        /// Get mail by unique id.
        /// </summary>
        /// <remarks>
        /// Request:
        /// /api/Mail/GetMail?id=3437030222
        /// 
        /// Response:
        ///{
        ///    "id": 3437030222,
        ///    "subject": "Hi!",
        ///    "message": "Hello",
        ///    "senderId": "address1@mail.ru",
        ///    "receiverId": "address2@mail.ru"
        ///}
        /// </remarks>
        /// <response code="200">Mail by id.</response>
        /// <response code="404">Mail is not found.</response>
        /// <param name="id">Mail id.</param>
        /// <returns>Mail.</returns>
        [HttpGet("GetMail")]
        public async Task<ActionResult<Mail>> GetMail(uint id)
        {
            var mail = await _mailRepository.Get(id);

            if (mail == null)
            {
                return NotFound("Mail is not found");
            }

            return mail;
        }

        /// <summary>
        /// Get sender's mails.
        /// </summary>
        /// <remarks>
        /// Request:
        /// /api/Mail/GetSenderMails?senderId=address1%40mail.ru
        /// 
        /// Response:
        ///{
        ///    "id": 3437030222,
        ///    "subject": "Hi!",
        ///    "message": "Hello",
        ///    "senderId": "address1@mail.ru",
        ///    "receiverId": "address2@mail.ru"
        ///}
        /// </remarks>
        /// <response code="200">Sender's mails.</response>
        /// <response code="404">Sender is not found.</response>
        /// <param name="senderId">Sender id - mail.</param>
        /// <returns>Sender's mails.</returns>
        [HttpGet("GetSenderMails")]
        public async Task<ActionResult<IEnumerable<Mail>>> GetSenderMails(string senderId)
        {
            var sender = await _userRepository.Get(senderId);

            return sender == null
                ? NotFound("Sender is not found")
                : new ActionResult<IEnumerable<Mail>>(await _mailRepository.GetSenderMails(senderId));
        }

        /// <summary>
        /// Get receiver's mails.
        /// </summary>
        /// <remarks>
        /// Request:
        /// /api/Mail/GetReceiverMails?receiverId=address2%40mail.ru
        /// 
        /// Response:
        ///{
        ///    "id": 3437030222,
        ///    "subject": "Hi!",
        ///    "message": "Hello",
        ///    "senderId": "address1@mail.ru",
        ///    "receiverId": "address2@mail.ru"
        ///}
        /// </remarks>
        /// <response code="200">Receiver's mails.</response>
        /// <response code="404">Receiver is not found.</response>
        /// <param name="receiverId">Receiver id - mail.</param>
        /// <returns>Receiver's mails.</returns>
        [HttpGet("GetReceiverMails")]
        public async Task<ActionResult<IEnumerable<Mail>>> GetReceiverMails(string receiverId)
        {
            var receiver = await _userRepository.Get(receiverId);

            return receiver == null
                ? NotFound("Receiver is not found")
                : new ActionResult<IEnumerable<Mail>>(await _mailRepository.GetReceiverMails(receiverId));
        }


        /// <summary>
        /// Sent new mail.
        /// </summary>
        /// <remarks>
        /// Request:
        /// curl -X POST "https://localhost:44390/api/Mail/SentMail" -H  "accept: */*" -H  "Content-Type: application/json" -d
        /// "{\"subject\":\"Hi!\",\"message\":\"Hello\",\"senderId\":\"address1@mail.ru\",\"receiverId\":\"address2@mail.ru\"}"
        /// 
        /// Response:
        ///{
        ///    "id": 3437030222,
        ///    "subject": "Hi!",
        ///    "message": "Hello",
        ///    "senderId": "address1@mail.ru",
        ///    "receiverId": "address2@mail.ru"
        ///}
        /// </remarks>
        /// <response code="200">Send mail.</response>
        /// <response code="404">Sender or receiver are not found.</response>
        /// <param name="mail">New mail.</param>
        /// <returns>Send mail.</returns>
        [HttpPost("SentMail")]
        public async Task<ActionResult> SentMail(Mail mail)
        {
            var sender = await _userRepository.Get(mail.SenderId);
            var receiver = await _userRepository.Get(mail.ReceiverId);

            if (sender == null || receiver == null)
            {
                return NotFound("Sender or receiver are not found");
            }

            var newMail = await _mailRepository.Create(mail);

            return CreatedAtAction(nameof(GetMail),
                new {id = newMail.Id, senderId = newMail.SenderId, receiverId = newMail.ReceiverId}, newMail);
        }

        ///  <summary>
        ///  Edit mail by mail id.
        ///  </summary>
        ///<remarks>
        /// Request:
        ///  curl -X PUT "https://localhost:44390/api/Mail/EditMail?id=3437030222" -H  "accept: */*" -H  "Content-Type: application/json"
        /// -d "{\"subject\":\"string\",\"message\":\"string\",\"senderId\":\"address1@mail.ru\",\"receiverId\":\"address2@mail.ru\"}"
        ///  
        ///  Response:
        ///  Mail is edited
        ///  </remarks>
        ///  <response code="200">Mail is edited.</response>
        ///  <response code="400">Incorrect sender or receiver emails.</response>
        ///  <response code="404">"Mail is not found.</response>
        ///  <param name="id">Unique mail id.</param>
        ///  <param name="mail">Updated mail.</param>
        ///  <returns>Message: Mail is edited.</returns>
        [HttpPut("EditMail")]
        public async Task<ActionResult> EditMail(uint id, [FromBody] Mail mail)
        {
            var mailToUpdate = await _mailRepository.Get(id);
            if (mailToUpdate == null)
            {
                return NotFound("Mail is not found");
            }

            if (mailToUpdate.ReceiverId != mail.ReceiverId || mailToUpdate.SenderId != mail.SenderId)
            {
                return BadRequest("Incorrect sender or receiver emails.");
            }

            mailToUpdate.Subject = mail.Subject;
            mailToUpdate.Message = mail.Message;
            await _mailRepository.Update(mailToUpdate);

            return Ok("Mail is edited");
        }

        /// <summary>
        /// Delete mail by id.
        /// </summary>
        /// <remarks>
        /// Request:
        ///  curl -X DELETE "https://localhost:44390/api/Mail/DeleteMail?id=3437030222" -H  "accept: */*"
        ///  
        ///  Response:
        ///  Mail is edited
        ///  </remarks>
        /// <response code="200">Mail is deleted.</response>
        /// <response code="404">Mail is not found.</response>
        /// <param name="id">Mail id.</param>
        /// <returns>Message: Mail is deleted.</returns>
        [HttpDelete("DeleteMail")]
        public async Task<ActionResult> DeleteMail(uint id)
        {
            var mail = await _mailRepository.Get(id);

            if (mail == null)
            {
                return NotFound("Mail is not found");
            }

            await _mailRepository.Delete(mail);

            return Ok("Mail is deleted");
        }



        /// <summary>
        /// Generate mails.
        /// </summary>
        /// <remarks>
        /// Request:
        ///  curl -X POST "https://localhost:44390/api/Mail/Generate" -H  "accept: */*" -d ""
        ///  
        ///  Response:
        ///  Mails are generated
        ///  </remarks>
        /// <response code="200">Mails are generated.</response>
        /// <response code="404">There are no users.</response>
        /// <returns>Message: Mail are generated; if there are no users-message: There are no users.</returns>
        [HttpPost("Generate")]
        public async Task<ActionResult> GenerateMails()
        {
            var users = (await _userRepository.Get()).ToList();

            if (!users.Any())
            {
                return BadRequest("There are no users.");
            }

            foreach (var user in users)
            {
                foreach (var other in users)
                {
                    await _mailRepository.Create(new Mail
                    {
                        SenderId = user.Email,
                        ReceiverId = other.Email,
                        Message = "Hello",
                        Subject = "Hi!"
                    });
                }
            }

            return Ok("Mails are generated");
        }
    }
}