using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Department : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int FacultyID { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual IEnumerable<Lessons> Lessons { get; set; }
        public virtual IEnumerable<Classrooms> Classrooms { get; set; }
        public virtual IEnumerable<Curriculum> Curriculum { get; set; }
    }
}
