using Lms.Comman.Domain.Entities;
using Lms.Common.Application.Dtos.Datatables;
using MediatR;

namespace Lms.Application.Features.QuestionCategory.Queries.GetQuestionCategoryPagedList
{
    public class GetQuestionCategoryPagedListQueryRequest:DtParameters, IRequest<IPagedDataResult<GetQuestionCategoryPagedListQueryResponse>>
    {
    }
}
