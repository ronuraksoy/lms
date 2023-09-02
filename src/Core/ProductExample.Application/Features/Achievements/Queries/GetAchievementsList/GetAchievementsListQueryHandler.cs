using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Achievements.Queries.GetAchievementsList
{
    public class GetAchievementsListQueryHandler : IRequestHandler<GetAchievementsListQueryRequest, IDataResult<IEnumerable<GetAchievementsListQueryResponse>>>
    {
        readonly IAchievementsRepository _achievementsRepository;
        IMapper _mapper;
        public GetAchievementsListQueryHandler(IAchievementsRepository achievementsRepository, IMapper mapper)
        {
            _achievementsRepository = achievementsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetAchievementsListQueryResponse>>> Handle(GetAchievementsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _achievementsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetAchievementsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetAchievementsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
