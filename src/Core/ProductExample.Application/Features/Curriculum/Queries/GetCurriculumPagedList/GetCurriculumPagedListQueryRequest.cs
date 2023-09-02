using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Curriculum.Queries.GetCurriculumPagedList
{
    public class GetCurriculumPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetCurriculumPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
