using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.AnnouncementStudent.Queries.GetAnnouncementStudentById
{
    public class GetAnnouncementStudentByIdQueryRequest : IRequest<IDataResult<GetAnnouncementStudentByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetAnnouncementStudentByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
