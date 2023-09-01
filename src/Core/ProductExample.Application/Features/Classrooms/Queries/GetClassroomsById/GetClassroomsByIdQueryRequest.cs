using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Classrooms.Queries.GetClassroomsById
{
    public class GetClassroomsByIdQueryRequest : IRequest<IDataResult<GetClassroomsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetClassroomsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
