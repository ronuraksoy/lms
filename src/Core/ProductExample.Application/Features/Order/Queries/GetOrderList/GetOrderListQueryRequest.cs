using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Order.Queries.GetOrderList
{
    public class GetOrderListQueryRequest : IRequest<IDataResult<IEnumerable<GetOrderListQueryResponse>>>
    {
    }
}
