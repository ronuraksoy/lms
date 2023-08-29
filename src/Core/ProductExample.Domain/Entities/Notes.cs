using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Notes : AAuditableEntity<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int LessonId { get; set; }
        public virtual Lessons Lessons { get; set; }
    }
}
