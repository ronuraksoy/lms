using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class StudentAssesments : AAuditableEntity<Guid>
    {
        public int ValidAnswerID { get; set; }
        public virtual ValidAnswers ValidAnswers { get; set; }
        public string StudentAnswerText { get; set; }
        public bool SatisFactory { get; set; }
        public string Asessment { get; set; }
        public string Details { get; set; }
    }
}
