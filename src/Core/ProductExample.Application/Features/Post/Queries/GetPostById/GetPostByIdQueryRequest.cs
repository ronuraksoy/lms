using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Post.Queries.GetPostById
{
    public class GetPostByIdQueryRequest : IRequest<IDataResult<GetPostByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetPostByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
