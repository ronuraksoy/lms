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
        readonly IAchievementCategoryRepository _categoryRepository;
        IMapper _mapper;
        public GetAchievementCategoryListQueryHandler(IAchievementCategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetAchievementCategoryListQueryResponse>>> Handle(GetAchievementCategoryListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _categoryRepository.GetListAsync();
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
