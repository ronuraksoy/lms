using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Product.Queries.GetProductPagedList
{
    public class GetProductPagedListQueryRequest: DtParameters, IRequest<IPagedDataResult<GetProductPagedListQueryResponse>>
    {
    }
}
