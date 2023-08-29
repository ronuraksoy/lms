using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class EventQuestions : AAuditableEntity<Guid>
    {
        public int EventID { get; set; }
        public virtual Events Events { get; set; }
        public int QuestionsID { get; set; }
        public virtual Questions Questions { get; set; }
    }
}
