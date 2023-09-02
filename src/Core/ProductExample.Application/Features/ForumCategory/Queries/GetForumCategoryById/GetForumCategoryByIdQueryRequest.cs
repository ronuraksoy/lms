using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.ForumCategory.Queries.GetForumCategoryById
{
    public class GetForumCategoryByIdQueryRequest : IRequest<IDataResult<GetForumCategoryByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetForumCategoryByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
