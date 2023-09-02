using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AchievementCategory.Queries.GetAchievementCategoryById
{
    public class GetAchievementCategoryByIdQueryHandler : IRequestHandler<GetAchievementCategoryByIdQueryRequest, IDataResult<GetAchievementCategoryByIdQueryResponse>>
    {
        readonly IAchievementCategoryRepository _achievementCategoryRepository;
        IMapper _mapper;
        public GetAchievementCategoryByIdQueryHandler(IAchievementCategoryRepository achievementCategoryRepository, IMapper mapper)
        {
            _achievementCategoryRepository = achievementCategoryRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetAchievementCategoryByIdQueryResponse>> Handle(GetAchievementCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _achievementCategoryRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetAchievementCategoryByIdQueryResponse>(data);
            return new DataResult<GetAchievementCategoryByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
