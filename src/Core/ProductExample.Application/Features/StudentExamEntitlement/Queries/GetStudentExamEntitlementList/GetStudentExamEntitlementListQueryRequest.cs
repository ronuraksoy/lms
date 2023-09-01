using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.StudentExamEntitlement.Queries.GetStudentExamEntitlementList
{
    public class GetStudentExamEntitlementListQueryRequest : IRequest<IDataResult<IEnumerable<GetStudentExamEntitlementListQueryResponse>>>
    {
    }
}
