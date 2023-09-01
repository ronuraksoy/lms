using Lms.Application.Features.Base;

namespace Lms.Application.Features.EventQuestions.Commands.CreateEventQuestions
{
    public class CreateEventQuestionsCommandRequest : BaseRequest
    {
        public int EventID { get; set; }
        public Lms.Domain.Entities.Events Events { get; set; }
        public int QuestionsID { get; set; }
        public Lms.Domain.Entities.Questions Questions { get; set; }
    }
}
