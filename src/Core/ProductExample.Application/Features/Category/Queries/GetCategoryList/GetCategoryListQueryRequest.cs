using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.Category.Queries.GetCategoryList
{
    public class GetCategoryListQueryRequest : IRequest<IDataResult<IEnumerable<GetCategoryListQueryResponse>>>
    {
    }
}
