using Lms.Comman.Domain.Entities;
using Lms.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Entities
{
    public class Questions : AAuditableEntity<Guid>
    {
        public int QuestionTypeID { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public string Question { get; set; }
        public string QuestionDetails { get; set; }
        public int QuestionCategoryID { get; set; }
        public virtual QuestionCategory QuestionCategory { get; set; }
        public string Level { get; set; }
        public ModulesCode? ModulesCode { get; set; }
        public virtual IEnumerable<Achievements> Achievements { get; set; }
        public virtual IEnumerable<EventParticipantsAnswer> EventParticipantsAnswers { get; set; }
        public virtual IEnumerable<EventQuestions> EventQuestions { get; set; }
        public virtual IEnumerable<ExamsQuestions> ExamsQuestions { get; set; }
        public virtual IEnumerable<ExamsQuestionsReport> ExamsQuestionsReports { get; set; }
        public virtual IEnumerable<StudentAnswers> StudentAnswers { get; set; }
        public virtual IEnumerable<ValidAnswers> ValidAnswers { get; set; }
    }
}
