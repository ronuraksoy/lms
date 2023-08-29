using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Achievements : AAuditableEntity<Guid>
    {
        public string Code { get; set; }
        public string AchievementDetails { get; set; }
        public int AchievementCategoryID { get; set; }
        public virtual AchievementCategory AchievementCategory { get; set; }
        public virtual IEnumerable<Questions> Questions { get; set; }
        public virtual IEnumerable<Educations> Educations{ get; set; }
    }
}
