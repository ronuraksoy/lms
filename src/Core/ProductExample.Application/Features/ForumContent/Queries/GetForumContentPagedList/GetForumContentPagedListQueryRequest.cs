using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.ForumContent.Queries.GetForumContentPagedList
{
    public class GetForumContentPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetForumContentPagedListQueryResponse>>
    {
    }
}
