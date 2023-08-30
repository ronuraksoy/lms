using Lms.Application.Features.Teacher.Queries.GetCategoryById;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
