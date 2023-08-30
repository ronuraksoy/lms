using Lms.Application.Features.Category.Queries.GetCategoryPagedList;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Post.Queries.GetPostPagedList
{
    public class GetPostPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetPostPagedListQueryResponse>>
    {
    }
}
