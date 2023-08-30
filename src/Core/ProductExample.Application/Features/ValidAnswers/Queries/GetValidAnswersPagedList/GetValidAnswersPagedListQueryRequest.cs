using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.ValidAnswers.Queries.GetValidAnswersPagedList
{
    public class GetValidAnswersPagedListQueryRequest : DtParameters, IRequest<IPagedDataResult<GetValidAnswersPagedListQueryResponse>>
    {
    }
}
