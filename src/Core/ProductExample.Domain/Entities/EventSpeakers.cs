using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class EventSpeakers : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Title { get; set; }
        public string LinkedIn { get; set; }
        public string Photo { get; set; }
        public string EventID { get; set; }
        public virtual Events Events { get; set; }
    }
}
