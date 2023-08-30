using Lms.Domain.Enums;

namespace Lms.Application.Features.Questions.Queries.GetQuestionById
{
    public class GetQuestionsByIdQueryResponse
    {
        public int QuestionTypeID { get; set; }
        public Lms.Domain.Entities.QuestionType QuestionType { get; set; }
        public string Question { get; set; }
        public string QuestionDetails { get; set; }
        public int QuestionCategoryID { get; set; }
        public  Lms.Domain.Entities.QuestionCategory QuestionCategory { get; set; }
        public string Level { get; set; }
        public ModulesCode? ModulesCode { get; set; }
    }
}
