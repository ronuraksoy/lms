using Lms.Application.Features.Teacher.Queries.GetCategoryList;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Post.Queries.GetPostList
{
    public class GetPostListQueryRequest : IRequest<IDataResult<IEnumerable<GetPostListQueryResponse>>>
    {
    }
}
