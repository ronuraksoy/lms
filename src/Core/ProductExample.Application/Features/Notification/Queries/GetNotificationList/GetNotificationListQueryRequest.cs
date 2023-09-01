using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Notification.Queries.GetNotificationList
{
    public class GetNotificationListQueryRequest : IRequest<IDataResult<IEnumerable<GetNotificationListQueryResponse>>>
    {
    }
}
