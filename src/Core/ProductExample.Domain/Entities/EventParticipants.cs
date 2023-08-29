using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class EventParticipants : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public int EventID { get; set; }
        public virtual Events Events { get; set; }
    }
}
