using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Product.Queries.GetProductList
{
    public class GetProductListQueryRequest : IRequest<IDataResult<IEnumerable<GetProductListQueryResponse>>>
    {
    }
}
