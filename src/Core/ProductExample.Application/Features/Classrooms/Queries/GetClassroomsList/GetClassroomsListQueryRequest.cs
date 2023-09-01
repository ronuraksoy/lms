using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Classrooms.Queries.GetClassroomsList
{
    public class GetClassroomsListQueryRequest : IRequest<IDataResult<IEnumerable<GetClassroomsListQueryResponse>>>
    {
    }
}
