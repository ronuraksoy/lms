using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.StudentAssesments.Queries.GetStudentAssesmentsList
{
    public class GetStudentAssesmentsListQueryRequest : IRequest<IDataResult<IEnumerable<GetStudentAssesmentsListQueryResponse>>>
    {
    }
}
