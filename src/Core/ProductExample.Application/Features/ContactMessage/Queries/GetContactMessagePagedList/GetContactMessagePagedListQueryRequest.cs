using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.ContactMessage.Queries.GetContactMessagePagedList
{
    public class GetContactMessagePagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetContactMessagePagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
