using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class ForumCategory : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public bool IsGeneral { get; set; }
        public int ForumID { get; set; }
        public virtual Forum Forum { get; set; }
    }
}
