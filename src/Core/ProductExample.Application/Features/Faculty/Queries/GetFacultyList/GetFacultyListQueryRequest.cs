using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Faculty.Queries.GetFacultyList
{
    public class GetFacultyListQueryRequest : IRequest<IDataResult<IEnumerable<GetFacultyListQueryResponse>>>
    {
    }
}
