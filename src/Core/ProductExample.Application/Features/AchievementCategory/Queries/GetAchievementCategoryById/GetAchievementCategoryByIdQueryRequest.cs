using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.AchievementCategory.Queries.GetAchievementCategoryById
{
    public class GetAchievementCategoryByIdQueryRequest : IRequest<IDataResult<GetAchievementCategoryByIdQueryResponse>>
    {
        public Guid Id { get; set; }

        public GetAchievementCategoryByIdQueryRequest(Guid Id) 
        {
            this.Id = Id;
        }
    }
}
