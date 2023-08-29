using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Faculty : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int SchoolID { get; set; }
        public virtual School School { get; set; }
        public virtual IEnumerable<Department> Departments { get; set; }
    }
}
