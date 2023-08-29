using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class AnnouncementStudent : AAuditableEntity<Guid>
    {
        public int ReciverID { get; set; }
        public virtual Student Student { get; set; }
        public int AnnouncementID { get; set; }
        public virtual Announcement Announcement { get; set; }
        public bool IsRead { get; set; }
    }
}
