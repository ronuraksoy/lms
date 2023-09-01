using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Post.Queries.GetPostPagedList
{
    public class GetPostPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetPostPagedListQueryResponse>>
    {
    }
}
