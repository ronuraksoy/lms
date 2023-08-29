using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class StudentAssignments : AAuditableEntity<Guid>
    {
        public string FilePath { get; set; }
        public string DriveLink { get; set; }
        public string Description { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public int EducationAssignmentsID { get; set; }
        public virtual EducationAssignments EducationAssignments { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
