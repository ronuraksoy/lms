using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.ExamsQuestionsReport.Queries.GetExamsQuestionsReportPagedList
{
    public class GetExamsQuestionsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetExamsQuestionsPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
