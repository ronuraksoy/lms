using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class EducationAssignments : AAuditableEntity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int OfferedCourseId { get; set; }
        public string FilePath { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public virtual IEnumerable<AssignmentResult> AssignmentResults { get; set; }
        public virtual IEnumerable<StudentAssignments> StudentAssignments { get; set; }
    }
}
