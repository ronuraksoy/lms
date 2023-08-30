using Lms.Comman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionType.Queries.GetQuestionTypePagedList
{
    public class GetQuestionTypePagedListQueryResponse:AAuditableEntity<Guid>
    {
        public string Name { get; set; }

    }
}
