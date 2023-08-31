using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.QuestionType.Queries.GetQuestionTypeList
{
    public class GetQuestionTypeListQueryRequest : IRequest<IDataResult<IEnumerable<GetQuestionTypeListQueryResponse>>>
    {
    }
}
