using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.EventQuestions.Queries.GetEventQuestionsPagedList
{
    public class GetEventQuestionsPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public int EventID { get; set; }
        public Lms.Domain.Entities.Events Events { get; set; }
        public int QuestionsID { get; set; }
        public Lms.Domain.Entities.Questions Questions { get; set; }
    }
}
