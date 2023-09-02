using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Forum.Queries.GetForumById
{
    public class GetForumByIdQueryRequest : IRequest<IDataResult<GetForumByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetForumByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
