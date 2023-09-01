using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Semester.Queries.GetSemesterList
{
    public class GetSemesterListQueryRequest : IRequest<IDataResult<IEnumerable<GetSemesterListQueryResponse>>>
    {
    }
}
