using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.AnnouncementStudent.Queries.GetAnnouncementStudentList
{
    public class GetAnnouncementStudentListQueryRequest : IRequest<IDataResult<IEnumerable<GetAnnouncementStudentListQueryResponse>>>
    {
    }
}
