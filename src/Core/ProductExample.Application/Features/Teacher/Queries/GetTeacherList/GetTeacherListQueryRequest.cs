using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Teacher.Queries.GetTeacherList
{
    public class GetTeacherListQueryRequest : IRequest<IDataResult<IEnumerable<GetTeacherListQueryResponse>>>
    {
    }
}
