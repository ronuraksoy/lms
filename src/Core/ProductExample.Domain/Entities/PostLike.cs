using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class PostLike : AAuditableEntity<Guid>
    {
        public DateTime CreatedOn { get; set; }
        public int PostID { get; set; }
        public virtual Post Post { get; set; }
        public int LikedID { get; set; }
        public virtual User User { get; set; }
    }
}
