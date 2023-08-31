using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Notification.Queries.GetNotificationPagedList
{
    public class GetNotificationPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetNotificationPagedListQueryResponse>>
    {
    }
}
