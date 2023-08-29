using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class QuestionType : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public virtual IEnumerable<Questions> Questions { get; set; }
    }
}
