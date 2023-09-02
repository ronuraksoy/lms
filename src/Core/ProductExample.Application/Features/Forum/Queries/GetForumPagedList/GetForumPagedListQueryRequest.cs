using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Forum.Queries.GetForumPagedList
{
    public class GetForumPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetForumPagedListQueryResponse>>
    {
    }
}
