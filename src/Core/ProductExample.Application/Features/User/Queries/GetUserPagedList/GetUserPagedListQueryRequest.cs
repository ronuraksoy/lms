using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.User.Queries.GetUserPagedList
{
    public class GetUserPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetUserPagedListQueryResponse>>
    {
    }
}
