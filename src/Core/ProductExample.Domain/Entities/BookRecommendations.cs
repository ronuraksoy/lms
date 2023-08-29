using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class BookRecommendations : AAuditableEntity<Guid>
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public int? TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
