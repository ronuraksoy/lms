using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Payment.Queries.GetPaymentPagedList
{
    public class GetPaymentPagedListQueryRequest: DtParameters, IRequest<IPagedDataResult<GetPaymentPagedListQueryResponse>>
    {
    }
}
