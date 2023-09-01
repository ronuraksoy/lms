using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Student.Queries.GetStudentById
{
    public class GetStudentByIdQueryRequest : IRequest<IDataResult<GetStudentByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetStudentByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
