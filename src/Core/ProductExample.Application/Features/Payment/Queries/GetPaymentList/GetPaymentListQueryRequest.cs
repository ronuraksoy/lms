using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Payment.Queries.GetPaymentList
{
    public class GetPaymentListQueryRequest: IRequest<IDataResult<IEnumerable<GetPaymentListQueryResponse>>>
    {
    }
}
