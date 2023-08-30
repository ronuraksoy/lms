using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.ValidAnswers.Queries.GetValidAnswersPagedList
{
    public class GetValidAnswersPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}
