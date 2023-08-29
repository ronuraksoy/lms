using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class ExamsQuestions : AAuditableEntity<Guid>
    {
        public int ExamsID { get; set; }
        public virtual Exams Exams { get; set; }
        public int QuestionsID { get; set; }
        public virtual Questions Questions { get; set; }
        public double QuestionsPoint { get; set; }
    }
}
