using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Comment.Queries.GetCommentById
{
    public class GetCommentByIdQueryRequest : IRequest<IDataResult<GetCommentByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetCommentByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
