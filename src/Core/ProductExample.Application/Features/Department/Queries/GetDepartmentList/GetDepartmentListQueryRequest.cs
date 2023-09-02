using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Department.Queries.GetDepartmentList
{
    public class GetDepartmentListQueryRequest : IRequest<IDataResult<IEnumerable<GetDepartmentListQueryResponse>>>
    {
    }
}
