using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Unit : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public int LessonID { get; set; }
        public virtual Lessons Lessons { get; set; }
        public virtual IEnumerable<Educations> Educations { get; set; }
    }
}
