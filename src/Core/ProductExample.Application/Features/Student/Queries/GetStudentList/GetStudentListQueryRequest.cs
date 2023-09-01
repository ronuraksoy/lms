using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Student.Queries.GetStudentList
{
    public class GetStudentListQueryRequest : IRequest<IDataResult<IEnumerable<GetStudentListQueryResponse>>>
    {
    }
}
