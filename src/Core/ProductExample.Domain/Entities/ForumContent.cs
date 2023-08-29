using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class ForumContent : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public bool IsGeneral { get; set; }
    }
}
