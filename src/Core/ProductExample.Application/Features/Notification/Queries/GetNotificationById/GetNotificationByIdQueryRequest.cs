using Lms.Application.Features.Notes.Queries.GetNotesById;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
