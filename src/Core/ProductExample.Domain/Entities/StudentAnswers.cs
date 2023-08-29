using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class StudentAnswers : AAuditableEntity<Guid>
    {
        public int ExamID { get; set; }
        public virtual Exams Exams { get; set; }
        public int QuestionID { get; set; }
        public virtual Questions Questions { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public DateTime AnswerDate { get; set; }
        public string Point { get; set; }
        public string StudentAnswer { get; set; }
        public string QuestionType { get; set; }
        public bool SatisFactory { get; set; }
        public bool IsNullAnswer { get; set; }
    }
}
