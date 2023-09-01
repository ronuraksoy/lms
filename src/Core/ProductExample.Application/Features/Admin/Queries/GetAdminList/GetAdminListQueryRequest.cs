using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Admin.Queries.GetAdminList
{
    public class GetAdminListQueryRequest : IRequest<IDataResult<IEnumerable<GetAdminListQueryResponse>>>
    {
    }
}
