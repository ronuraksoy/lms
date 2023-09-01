using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Order.Queries.GetOrderPagedList
{
    public class GetOrderPagedListQueryRequest: DtParameters, IRequest<IPagedDataResult<GetOrderPagedListQueryResponse>>
    {
    }
}
