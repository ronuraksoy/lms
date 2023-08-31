using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.QuestionCategory.Queries.GetQuestionCategoryPagedList
{
    public class GetQuestionCategoryPagedListQueryResponse: AAuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
