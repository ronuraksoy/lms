using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AchievementCategory.Queries.GetAchievementCategoryPagedList
{
    public class GetAchievementCategoryPagedListQueryHandler : IRequestHandler<GetAchievementCategoryPagedListQueryRequest, IPagedDataResult<GetAchievementCategoryPagedListQueryResponse>>
    {
        readonly IAchievementCategoryRepository _achievementCategoryRepository;
        IMapper _mapper;
        public Task<IPagedDataResult<GetAchievementCategoryPagedListQueryResponse>> Handle(GetAchievementCategoryPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public GetAchievementCategoryPagedListQueryHandler(IAchievementCategoryRepository achievementCategoryRepository, IMapper mapper)
        {
            _achievementCategoryRepository = achievementCategoryRepository;
            _mapper = mapper;
        }
    }
}
