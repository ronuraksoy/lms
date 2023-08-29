using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class StudentQuestions : AAuditableEntity<Guid>
    {
        public int LessonId { get; set; }
        public virtual Lessons Lessons { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Image { get; set; }
        public string Document { get; set; }
    }
}
