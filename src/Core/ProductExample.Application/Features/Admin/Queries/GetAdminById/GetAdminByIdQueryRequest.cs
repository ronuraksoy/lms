using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Admin.Queries.GetAdminById
{
    public class GetAdminByIdQueryRequest : IRequest<IDataResult<GetAdminByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetAdminByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
