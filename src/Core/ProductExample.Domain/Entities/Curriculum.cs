using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Curriculum : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department{ get; set; }
        public virtual IEnumerable<CurriculumLesson> CurriculumLessons { get; set; }
    }
}
