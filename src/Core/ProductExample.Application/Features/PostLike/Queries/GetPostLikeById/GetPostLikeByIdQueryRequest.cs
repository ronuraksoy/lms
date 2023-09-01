using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.PostLike.Queries.GetCategoryById
{
    public class GetPostLikeByIdQueryRequest : IRequest<IDataResult<GetPostLikeByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetPostLikeByIdQueryRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
