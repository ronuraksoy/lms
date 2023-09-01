using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.ValidAnswers.Queries.GetValidAnswersList
{
    public class GetValidAnswersListQueryRequest : IRequest<IDataResult<IEnumerable<GetValidAnswersListQueryResponse>>>
    {
    }
}
