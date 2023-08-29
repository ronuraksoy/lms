using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class AssignmentResult : AAuditableEntity<Guid>
    {
        public int EducationAssignmentID { get; set; }
        public virtual EducationAssignments EducationAssignments { get; set; }
        public int StudenAssignmentID { get; set; }
        public virtual Student Student { get; set; }
        public double Point { get; set; }
        public string Status { get; set; } = "Bekleniyor";
    }
}
