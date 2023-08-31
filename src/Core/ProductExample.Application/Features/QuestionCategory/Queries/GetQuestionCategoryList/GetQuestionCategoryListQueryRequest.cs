using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.QuestionCategory.Queries.GetQuestionCategoryList
{
    public class GetQuestionCategoryListQueryRequest : IRequest<IDataResult<IEnumerable<GetQuestionCategoryListQueryResponse>>>
    {
    }
}
