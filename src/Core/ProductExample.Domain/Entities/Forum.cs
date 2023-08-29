using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Forum : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime DateTime { get; set; }
        public int CreatedUserID { get; set; }
        public virtual User User { get; set; }
        public virtual IEnumerable<ForumCategory> ForumCategories { get; set; }

    }
}
