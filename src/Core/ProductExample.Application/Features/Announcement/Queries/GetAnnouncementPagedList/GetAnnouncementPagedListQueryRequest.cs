using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Announcement.Queries.GetAnnouncementPagedList
{
    public class GetAnnouncementPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetAnnouncementPagedListQueryResponse>>
    {
    }
}
