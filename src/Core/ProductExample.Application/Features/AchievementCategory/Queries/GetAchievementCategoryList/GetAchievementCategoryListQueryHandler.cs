using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AchievementCategory.Queries.GetAchievementCategoryList
{
    public class GetAchievementCategoryListQueryHandler : IRequestHandler<GetAchievementCategoryListQueryRequest, IDataResult<IEnumerable<GetAchievementCategoryListQueryResponse>>>
    {
        readonly IAchievementCategoryRepository _achievementCategoryRepository;
        IMapper _mapper;
        public GetAchievementCategoryListQueryHandler(IAchievementCategoryRepository achievementCategoryRepository, IMapper mapper)
        {
            _achievementCategoryRepository = achievementCategoryRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetAchievementCategoryListQueryResponse>>> Handle(GetAchievementCategoryListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _achievementCategoryRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetAchievementCategoryListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetAchievementCategoryListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
