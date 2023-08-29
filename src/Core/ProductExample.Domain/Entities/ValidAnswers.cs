using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class ValidAnswers : AAuditableEntity<Guid>
    {
        public int QuestionID { get; set; }
        public virtual Questions Questions { get; set; }
        public string ValidAnswerText { get; set; }
        public bool IsTrue { get; set; }
        public virtual IEnumerable<StudentAssesments> StudentAssesments { get; set; }
    }
}
