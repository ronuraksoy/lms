using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.QuestionType.Queries.GetQuestionTypePagedList
{
    public class GetQuestionTypePagedListQueryResponse:AAuditableEntity<Guid>
    {
        public string Name { get; set; }

    }
}
