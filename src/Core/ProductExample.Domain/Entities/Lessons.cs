using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Lessons : AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public string ImagePath { get; set; }
        public int Hour { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Certificate { get; set; }
        public int CategoriesID { get; set; }
        public virtual Category Category { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public virtual IEnumerable<Notes> Notes { get; set; }
        public virtual IEnumerable<CurriculumLesson> CurriculumLessons { get; set; }
        public virtual IEnumerable<Unit> Units { get; set; }
        public virtual IEnumerable<StudentQuestions> StudentQuestions { get; set; }
    }
}
