using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace ChatAPI.Models
{
    public class Mail : IEquatable<Mail>
    {
        /// <summary>
        /// Mail unique id.
        /// </summary>
        [Key] public uint Id { get; private set; }
        /// <summary>
        /// Mail's subject.
        /// </summary>
        [Required] public string Subject { get; set; }
        /// <summary>
        /// Mail message.
        /// </summary>
        [Required] public string Message { get; set; }
        /// <summary>
        /// Mail sender id.
        /// </summary>
        [Required] public string SenderId { get; set; }
        /// <summary>
        /// Mail receiver id.
        /// </summary>
        [Required] public string ReceiverId { get; set; }

        /// <summary>
        /// Generate id.
        /// </summary>
        public Mail()
        {
            var md5 = MD5.Create();
            var obj = Guid.NewGuid();
            var str = obj.ToString();
            Id = BitConverter.ToUInt32(md5.ComputeHash(Encoding.Default.GetBytes(str)), 0);
        }

        /// <summary>
        /// Check for equals.
        /// </summary>
        /// <param name="other">Other mail.</param>
        /// <returns>Result of checking.</returns>
        public bool Equals(Mail other)
        {
            return Id == other.Id && SenderId == other.SenderId && ReceiverId == other.ReceiverId;
        }

        /// <summary>
        /// Check for equals.
        /// </summary>
        /// <param name="obj">Other mail.</param>
        /// <returns>Result of checking.</returns>
        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType() == this.GetType() && Equals((Mail) obj);
        }

        /// <summary>
        /// Unique hash code.
        /// </summary>
        /// <returns>Mail hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, SenderId, ReceiverId);
        }
    }
}