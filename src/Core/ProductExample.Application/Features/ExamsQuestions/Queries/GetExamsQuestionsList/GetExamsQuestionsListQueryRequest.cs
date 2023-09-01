using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.ExamsQuestions.Queries.GetExamsQuestionsList
{
    public class GetExamsQuestionsListQueryRequest : IRequest<IDataResult<IEnumerable<GetExamsQuestionsListQueryResponse>>>
    {
    }
}
