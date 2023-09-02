using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Department.Queries.GetDepartmentById
{
    public class GetDepartmentByIdQueryRequest : IRequest<IDataResult<GetDepartmentByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetDepartmentByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
