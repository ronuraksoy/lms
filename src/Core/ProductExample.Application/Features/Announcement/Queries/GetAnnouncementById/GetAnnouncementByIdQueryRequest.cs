using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Announcement.Queries.GetAnnouncementById
{
    public class GetAnnouncementByIdQueryRequest : IRequest<IDataResult<GetAnnouncementByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetAnnouncementByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
