using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.CurriculumLesson.Queries.GetCurriculumLessonList
{
    public class GetCurriculumLessonListQueryRequest : IRequest<IDataResult<IEnumerable<GetCurriculumLessonListQueryResponse>>>
    {
    }
}
