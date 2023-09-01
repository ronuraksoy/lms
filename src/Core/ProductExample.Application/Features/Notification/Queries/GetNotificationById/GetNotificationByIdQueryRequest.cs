using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Notification.Queries.GetNotificationById
{
    public class GetNotificationByIdQueryRequest:IRequest<IDataResult<GetNotificationByIdQueryResponse>>
    {
        public Guid Id { get; set; }
        public GetNotificationByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
