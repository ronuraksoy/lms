using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.EventQuestions.Queries.GetEventQuestionsPagedList
{
    public class GetEventQuestionsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetEventQuestionsPagedListQueryResponse>>
    {
        public string? NameFilter { get; set; }
    }
}
