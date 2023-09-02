using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Achievements.Queries.GetAchievementsById
{
    public class GetAchievementsByIdQueryHandler : IRequestHandler<GetAchievementsByIdQueryRequest, IDataResult<GetAchievementsByIdQueryResponse>>
    {
        readonly IAchievementsRepository _achievementsRepository;
        IMapper _mapper;
        public GetAchievementsByIdQueryHandler(IAchievementsRepository achievementsRepository, IMapper mapper)
        {
            _achievementsRepository = achievementsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetAchievementsByIdQueryResponse>> Handle(GetAchievementsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _achievementsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetAchievementsByIdQueryResponse>(data);
            return new DataResult<GetAchievementsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
