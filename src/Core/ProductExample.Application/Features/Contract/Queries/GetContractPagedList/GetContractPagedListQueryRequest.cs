using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Contract.Queries.GetContractPagedList
{
    public class GetContractPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetContractPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
