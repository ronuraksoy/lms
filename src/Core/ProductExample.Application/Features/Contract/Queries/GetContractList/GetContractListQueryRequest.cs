using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Contract.Queries.GetContractList
{
    public class GetContractListQueryRequest : IRequest<IDataResult<IEnumerable<GetContractListQueryResponse>>>
    {
    }
}
