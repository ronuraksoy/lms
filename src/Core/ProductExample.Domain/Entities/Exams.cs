using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Exams : AAuditableEntity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
        public int? EducationID { get; set; }
        public virtual Educations Educations { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Time { get; set; }
        public DateTime Hour { get; set; }
        public bool FeedBack { get; set; }
        public int ExamEntitlement { get; set; }
        public bool QuestionNav { get; set; }
        public virtual IEnumerable<ExamsQuestions> ExamsQuestions { get; set; }
        public virtual IEnumerable<ExamsQuestionsReport> ExamsQuestionsReports { get; set; }
        public virtual IEnumerable<StudentAnswers> StudentAnswers { get; set; }
        public virtual IEnumerable<StudentExamEntitlement> StudentExamEntitlements { get; set; }
        public virtual IEnumerable<StudentExamLogs> StudentExamLogs { get; set; }
    }
}
