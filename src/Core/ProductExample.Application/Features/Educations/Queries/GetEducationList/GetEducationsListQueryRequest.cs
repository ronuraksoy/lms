using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Educations.Queries.GetEducationsList
{
    public class GetEducationsListQueryRequest : IRequest<IDataResult<IEnumerable<GetEducationsListQueryResponse>>>
    {
    }
}
