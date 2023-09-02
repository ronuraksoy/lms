using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Achievements.Queries.GetAchievementsById
{
    public class GetAchievementsByIdQueryRequest : IRequest<IDataResult<GetAchievementsByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetAchievementsByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
