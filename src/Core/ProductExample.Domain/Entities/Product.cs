using Lms.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public Guid OrderId { get; set; }
        public virtual User Order { get; set; }
    }
}
