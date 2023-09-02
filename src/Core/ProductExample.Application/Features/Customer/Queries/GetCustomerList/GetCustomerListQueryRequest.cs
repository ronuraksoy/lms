using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Customer.Queries.GetCustomerList
{
    public class GetCustomerListQueryRequest : IRequest<IDataResult<IEnumerable<GetCustomerListQueryResponse>>>
    {
    }
}
