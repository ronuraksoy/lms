using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Contract: AAuditableEntity<Guid>
    {
        public string EduPrice { get; set; }
        public int? LessonsID { get; set; }
        public virtual Lessons Lessons { get; set; }
        public string PricePerMonth { get; set; }
        public int EndDate { get; set; }
        public virtual IEnumerable<Customer> Customers { get; set; }
        public virtual IEnumerable<Payment> Payments { get; set; }
    }
}
