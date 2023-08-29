using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class ExamsQuestionsReport : AAuditableEntity<Guid>
    {
        public int ExamsID { get; set; }
        public virtual Exams Exams { get; set; }
        public int QuestionsID { get; set; }
        public virtual Questions Questions { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public DateTime DateTime { get; set; }
    }
}
