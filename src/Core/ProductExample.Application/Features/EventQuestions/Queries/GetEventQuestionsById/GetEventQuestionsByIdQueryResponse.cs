namespace Lms.Application.Features.EventQuestions.Queries.GetEventQuestionsById
{
    public class GetEventQuestionsByIdQueryResponse
    {
        public int EventID { get; set; }
        public Lms.Domain.Entities.Events Events { get; set; }
        public int QuestionsID { get; set; }
        public Lms.Domain.Entities.Questions Questions { get; set; }
    }
}
