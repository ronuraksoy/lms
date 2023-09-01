using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Exams.Queries.GetExamsList
{
    public class GetExamsListQueryRequest : IRequest<IDataResult<IEnumerable<GetExamsListQueryResponse>>>
    {
    }
}
