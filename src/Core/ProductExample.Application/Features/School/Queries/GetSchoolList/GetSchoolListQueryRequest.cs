using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.School.Queries.GetSchoolList
{
    public class GetSchoolListQueryRequest : IRequest<IDataResult<IEnumerable<GetSchoolListQueryResponse>>>
    {
    }
}
