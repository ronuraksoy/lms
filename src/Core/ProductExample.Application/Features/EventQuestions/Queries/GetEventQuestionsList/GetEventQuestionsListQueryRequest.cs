using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.EventQuestions.Queries.GetEventQuestionsList
{
    public class GetEventQuestionsListQueryRequest : IRequest<IDataResult<IEnumerable<GetEventQuestionsListQueryResponse>>>
    {
    }
}
