using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.CurriculumLesson.Queries.GetCurriculumLessonPagedList
{
    public class GetCurriculumLessonPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetCurriculumLessonPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
