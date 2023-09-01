using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.Questions.Queries.GetQuestionPagedList
{
    public class GetQuestionsPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetQuestionsPagedListQueryResponse>>
    {
    }
}
