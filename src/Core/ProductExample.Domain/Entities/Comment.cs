using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities   
{
    public class Comment : AAuditableEntity<Guid>
    {
        public DateTime CreatedOn { get; set; }
        public string Message { get; set; }
        public int ModuleCode { get; set; }
        public int SenderID { get; set; }
        public virtual User SenderUser { get; set; }
        public int ReciverID { get; set; }
        public virtual User ReciverUser { get; set; }
        public bool FromStudent { get; set; }
        public int ControlOneID { get; set; }
    }
}
