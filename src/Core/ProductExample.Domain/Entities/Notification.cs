using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Notification : AAuditableEntity<Guid>
    {
        public string Content { get; set; }
        public char SendUserType { get; set; }
        public int SendUserID { get; set; }
        public virtual User SenderUser { get; set; }
        public int ComeUserID { get; set; }
        public virtual User ComeUser { get; set; }
        public DateTime NotificationTime { get; set; }
        public bool IsRead { get; set; }
    }
}
