using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class StudentExamEntitlement : AAuditableEntity<Guid>
    {
        public int ExamID { get; set; }
        public virtual Exams Exams { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public int ExamEntitlementCount { get; set; }
    }
}