using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Lms.Application.Features.BookRecommendations.Queries.GetBookRecommendationsList
{
    public class GetBookRecommendationsListQueryRequest : IRequest<IDataResult<IEnumerable<GetBookRecommendationsListQueryResponse>>>
    {
    }
}
