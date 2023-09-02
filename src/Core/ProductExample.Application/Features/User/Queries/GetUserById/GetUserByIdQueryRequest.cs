using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.User.Queries.GetUserById
{
    public class GetUserByIdQueryRequest : IRequest<IDataResult<GetUserByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetUserByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
