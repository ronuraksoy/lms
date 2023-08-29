using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Category : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public int Hour { get; set; }
        public virtual IEnumerable<Student> Students { get; set; }
        public virtual IEnumerable<Lessons> Lessons { get; set; }

    }
}
