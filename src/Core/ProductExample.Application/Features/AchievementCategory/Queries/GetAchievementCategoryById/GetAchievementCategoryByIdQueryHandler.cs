using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Teacher.Queries.GetAchievementCategoryById
{
    public class GetAchievementCategoryByIdQueryHandler : IRequestHandler<GetAchievementCategoryByIdQueryRequest, IDataResult<GetAchievementCategoryByIdQueryResponse>>
    {
        readonly ICategoryRepository _categoryRepository;
        IMapper _mapper;
        public GetAchievementCategoryByIdQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetAchievementCategoryByIdQueryResponse>> Handle(GetAchievementCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _categoryRepository.GetByIdAsync(request);
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
