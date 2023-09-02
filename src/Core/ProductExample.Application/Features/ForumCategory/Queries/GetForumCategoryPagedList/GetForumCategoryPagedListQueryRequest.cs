using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.ForumCategory.Queries.GetForumCategoryPagedList
{
    public class GetForumCategoryPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetForumCategoryPagedListQueryResponse>>
    {
    }
}
