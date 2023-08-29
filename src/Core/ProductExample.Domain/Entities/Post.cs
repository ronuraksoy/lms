using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Post : AAuditableEntity<Guid>
    {
        public DateTime CreatedOn { get; set; }
        public string Message { get; set; }
        public int SenderID { get; set; }
        public virtual User User { get; set; }
        public virtual IEnumerable<PostLike> PostLikes{ get; set; }
    }
}
