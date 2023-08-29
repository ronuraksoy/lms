using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class CurriculumLesson : AAuditableEntity<Guid>
    {
        public int LessonId { get; set; }
        public virtual Lessons Lessons { get; set; }
        public int CurriculumId { get; set; }
        public virtual Curriculum Curriculum{ get; set; }
        public string Period { get; set; }
        public string Hour { get; set; } //Haftalık saat
        public decimal Credit { get; set; }//Kredi
        public decimal LocalCredit { get; set; }//Yerel Kredi
        public decimal Application { get; set; }//Uygulama saati
        public decimal Lab { get; set; }//Lab saati
    }
}
