using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Message.Queries.GetMessagePagedList
{
    public class GetMessagePagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetMessagePagedListQueryResponse>>
    {
    }
}
