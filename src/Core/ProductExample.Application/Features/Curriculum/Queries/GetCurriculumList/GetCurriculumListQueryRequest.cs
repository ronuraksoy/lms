using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Curriculum.Queries.GetCurriculumList
{
    public class GetCurriculumListQueryRequest : IRequest<IDataResult<IEnumerable<GetCurriculumListQueryResponse>>>
    {
    }
}
