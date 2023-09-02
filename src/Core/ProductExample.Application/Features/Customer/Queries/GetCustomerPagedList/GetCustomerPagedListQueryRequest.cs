using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Customer.Queries.GetCustomerPagedList
{
    public class GetCustomerPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetCustomerPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
