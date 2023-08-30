using Lms.Application.Features.Teacher.Queries.GetCategoryList;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Order.Queries.GetOrderList
{
    public class GetOrderListQueryRequest : IRequest<IDataResult<IEnumerable<GetOrderListQueryResponse>>>
    {
    }
}
