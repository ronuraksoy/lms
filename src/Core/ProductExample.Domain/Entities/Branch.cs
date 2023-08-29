using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Branch:AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public virtual IEnumerable<Teacher> Teachers { get; set; }
    }
}
