using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.PostLike.Queries.GetPostLikePagedList
{
    public class GetPostLikePagedListQueryRequest: DtParameters, IRequest<IPagedDataResult<GetPostLikePagedListQueryResponse>>
    {
    }
}
