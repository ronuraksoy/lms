using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Payment.Queries.GetPaymentList
{
    public class GetPaymentListQueryRequest: IRequest<IDataResult<IEnumerable<GetPaymentListQueryResponse>>>
    {
    }
}
