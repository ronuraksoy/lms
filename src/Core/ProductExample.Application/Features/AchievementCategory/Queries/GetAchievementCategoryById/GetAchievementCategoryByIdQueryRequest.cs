using Lms.Comman.Domain.Entities;
using MediatR;
using System;

namespace Lms.Application.Features.Teacher.Queries.GetAchievementCategoryById
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
