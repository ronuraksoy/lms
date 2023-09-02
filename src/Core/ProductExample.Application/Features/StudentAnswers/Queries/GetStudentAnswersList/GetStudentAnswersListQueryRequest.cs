using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.StudentAnswers.Queries.GetStudentAnswersList
{
    public class GetStudentAnswersListQueryRequest : IRequest<IDataResult<IEnumerable<GetStudentAnswersListQueryResponse>>>
    {
    }
}
