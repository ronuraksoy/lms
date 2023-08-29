using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Payment: AAuditableEntity<Guid>
    {
        public string EducationPay { get; set; }
        public string Note { get; set; }
    }
}
