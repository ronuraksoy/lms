using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Comment.Queries.GetCommentPagedList
{
    public class GetCommentPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetCommentPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
