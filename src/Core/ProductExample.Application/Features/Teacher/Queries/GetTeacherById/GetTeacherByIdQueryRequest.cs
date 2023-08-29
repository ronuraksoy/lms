using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Teacher.Queries.GetTeacherById
{
    public class GetTeacherByIdQueryRequest : IRequest<IDataResult<GetTeacherByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetTeacherByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
