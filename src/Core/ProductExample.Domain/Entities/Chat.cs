using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Chat : AAuditableEntity<Guid>
    {
        public Chat()
        {
            Messages = new List<Message>();
        }
        public int? CreatedUserId { get; set; }
        public virtual User CreatedUser { get; set; }
        public int? ReceiverId { get; set; }
        public virtual User Receiver { get; set; }
        public virtual IEnumerable<Message> Messages { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
