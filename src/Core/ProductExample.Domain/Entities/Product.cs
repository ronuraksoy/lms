using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Domain.Entities
{
    public class Product : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}