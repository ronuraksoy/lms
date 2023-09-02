using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Document.Queries.GetDocumentPagedList
{
    public class GetDocumentPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetDocumentPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
