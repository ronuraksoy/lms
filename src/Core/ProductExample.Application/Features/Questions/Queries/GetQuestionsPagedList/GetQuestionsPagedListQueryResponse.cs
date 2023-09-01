using Lms.Comman.Domain.Entities;
using Lms.Domain.Enums;
using System;

namespace Lms.Application.Features.Questions.Queries.GetQuestionPagedList
{
    public class GetQuestionsPagedListQueryResponse: AAuditableEntity<Guid>
    {
        public int QuestionTypeID { get; set; }
        public Lms.Domain.Entities.QuestionType QuestionType { get; set; }
        public string Question { get; set; }
        public string QuestionDetails { get; set; }
        public int QuestionCategoryID { get; set; }
        public Lms.Domain.Entities.QuestionCategory QuestionCategory { get; set; }
        public string Level { get; set; }
        public ModulesCode? ModulesCode { get; set; }
    }
}
