using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.AnnouncementStudent.Queries.GetAnnouncementStudentPagedList
{
    public class GetAnnouncementStudentPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetAnnouncementStudentPagedListQueryResponse>>
    {
    }
}
