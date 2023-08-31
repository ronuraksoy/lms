using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.QuestionType.Queries.GetQuestionTypePagedList
{
    public class GetQuestionTypePagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetQuestionTypePagedListQueryResponse>>
    {
    }
}
