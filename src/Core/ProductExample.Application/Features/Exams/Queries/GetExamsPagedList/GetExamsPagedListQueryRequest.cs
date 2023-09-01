using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Exams.Queries.GetExamsPagedList
{
    public class GetExamsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetExamsPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
