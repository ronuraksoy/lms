using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Questions.Queries.GetQuestionList
{
    public class GetQuestionsListQueryRequest : IRequest<IDataResult<IEnumerable<GetQuestionsListQueryResponse>>>
    {
    }
}
