using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Educations : AAuditableEntity<Guid>
    {
        public Educations()
        {
            Documents = new List<Document>();
            Achievements = new List<Achievements>();
        }
        public string Name { get; set; }
        public string ExamLink { get; set; }
        public int TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
        public int? UnitID { get; set; }
        public virtual Unit Unit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Content { get; set; }
        public string Logo { get; set; }
        public string Path { get; set; }
        public bool IsLive { get; set; }
        public int StudentID { get; set; }
        public virtual IEnumerable<Document> Documents { get; set; }
        public IEnumerable<Achievements> Achievements { get; set; }
        public virtual IEnumerable<Exams> Exams { get; set; }
    }
}
