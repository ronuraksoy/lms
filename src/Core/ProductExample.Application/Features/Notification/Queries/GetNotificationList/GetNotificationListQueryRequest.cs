using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notification.Queries.GetNotificationList
{
    public class GetNotificationListQueryRequest : IRequest<IDataResult<IEnumerable<GetNotificationListQueryResponse>>>
    {
    }
}
