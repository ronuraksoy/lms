using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Announcement : AAuditableEntity<Guid>
    {
        public int CreatedUserID { get; set; }
        public virtual User User { get; set; }
        public int ReciverType { get; set; }
        public string Topic { get; set; }
        public string Contents { get; set; }
        public virtual IEnumerable<AnnouncementStudent> AnnouncementStudents { get; set; }
    }
}
