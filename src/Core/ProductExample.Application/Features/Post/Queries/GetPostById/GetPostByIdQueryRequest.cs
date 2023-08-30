using Lms.Application.Features.Teacher.Queries.GetCategoryById;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Post.Queries.GetCategoryById
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
