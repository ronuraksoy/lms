using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Unit.Queries.GetUnitPagedList
{
    public class GetUnitPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetUnitPagedListQueryResponse>>
    {
    }
}
