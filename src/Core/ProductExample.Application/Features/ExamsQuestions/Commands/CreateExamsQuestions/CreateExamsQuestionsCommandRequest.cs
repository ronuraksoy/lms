using Lms.Application.Features.Base;

namespace Lms.Application.Features.ExamsQuestions.Commands.CreateExamsQuestions
{
    public class CreateExamsQuestionsCommandRequest : BaseRequest
    {
        public int ExamsID { get; set; }
        public Lms.Domain.Entities.Exams Exams { get; set; }
        public int QuestionsID { get; set; }
        public Lms.Domain.Entities.Questions Questions { get; set; }
        public double QuestionsPoint { get; set; }
    }
}
