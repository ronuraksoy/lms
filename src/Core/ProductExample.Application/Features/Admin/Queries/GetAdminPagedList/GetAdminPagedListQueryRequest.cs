using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Admin.Queries.GetAdminPagedList
{
    public class GetAdminPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetAdminPagedListQueryResponse>>
    {
    }
}
