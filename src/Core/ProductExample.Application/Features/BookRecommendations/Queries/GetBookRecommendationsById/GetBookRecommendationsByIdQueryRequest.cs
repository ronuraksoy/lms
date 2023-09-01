using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.BookRecommendations.Queries.GetBookRecommendationsById
{
    public class GetBookRecommendationsByIdQueryRequest : IRequest<IDataResult<GetBookRecommendationsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetBookRecommendationsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
