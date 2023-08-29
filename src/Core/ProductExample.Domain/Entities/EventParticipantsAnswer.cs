using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class EventParticipantsAnswer : AAuditableEntity<Guid>
    {
        public int EventID { get; set; }
        public virtual Events Events { get; set; }
        public int QuestionID { get; set; }
        public virtual Questions Questions { get; set; }
        public int ParticipantID { get; set; }
        public virtual User User { get; set; }
        public DateTime AnswerDate { get; set; }
        public string Answer { get; set; }
    }
}
