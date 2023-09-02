using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.ForumContent.Queries.GetForumContentById
{
    public class GetForumContentByIdQueryRequest : IRequest<IDataResult<GetForumContentByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetForumContentByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
