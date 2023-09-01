using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Semester.Queries.GetSemesterPagedList
{
    public class GetSemesterPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetSemesterPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
