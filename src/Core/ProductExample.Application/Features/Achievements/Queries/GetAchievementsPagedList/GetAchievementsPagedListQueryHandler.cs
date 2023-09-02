using AutoMapper;
using Lms.Application.Features.Announcement.Queries.GetAnnouncementPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Achievements.Queries.GetAchievementsPagedList
{
    public class GetAchievementsPagedListQueryHandler : IRequestHandler<GetAchievementsPagedListQueryRequest, IPagedDataResult<GetAchievementsPagedListQueryResponse>>
    {
        readonly IAchievementsRepository _achievementsRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetAchievementsPagedListQueryResponse>> Handle(GetAchievementsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _achievementsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetAchievementsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetAchievementsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetAchievementsPagedListQueryHandler(IAchievementsRepository achievementsRepository, IMapper mapper)
        {
            _achievementsRepository = achievementsRepository;
            _mapper = mapper;
        }
    }
}
