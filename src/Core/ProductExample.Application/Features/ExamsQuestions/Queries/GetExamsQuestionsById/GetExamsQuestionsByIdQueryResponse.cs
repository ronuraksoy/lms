namespace Lms.Application.Features.ExamsQuestions.Queries.GetExamsQuestionsById
{
    public class GetExamsQuestionsByIdQueryResponse
    {
        public int ExamsID { get; set; }
        public Lms.Domain.Entities.Exams Exams { get; set; }
        public int QuestionsID { get; set; }
        public Lms.Domain.Entities.Questions Questions { get; set; }
        public double QuestionsPoint { get; set; }
    }
}
