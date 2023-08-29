using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Classrooms : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public bool IsLab { get; set; }
        public int NumberOfSeats { get; set; }
        public int Floor { get; set; }
        public string Block { get; set; }
    }
}
