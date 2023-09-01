using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.BookRecommendations.Queries.GetBookRecommendationsPagedList
{
    public class GetBookRecommendationsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetBookRecommendationsPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
