using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Faculty.Queries.GetFacultyById
{
    public class GetFacultyByIdQueryRequest : IRequest<IDataResult<GetFacultyByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetFacultyByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
