using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class QuestionCategory : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual IEnumerable<Questions> Questions { get; set; }
    }
}
