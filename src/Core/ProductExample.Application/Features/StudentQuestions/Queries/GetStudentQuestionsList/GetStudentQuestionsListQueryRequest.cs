using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.StudentQuestions.Queries.GetStudentQuestionsList
{
    public class GetStudentQuestionsListQueryRequest : IRequest<IDataResult<IEnumerable<GetStudentQuestionsListQueryResponse>>>
    {
    }
}
