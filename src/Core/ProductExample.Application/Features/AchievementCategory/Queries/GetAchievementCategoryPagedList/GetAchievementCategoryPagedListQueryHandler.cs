using AutoMapper;
using Lms.Application.Features.Announcement.Queries.GetAnnouncementPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AchievementCategory.Queries.GetAchievementCategoryPagedList
{
    public class GetAchievementCategoryPagedListQueryHandler : IRequestHandler<GetAchievementCategoryPagedListQueryRequest, IPagedDataResult<GetAchievementCategoryPagedListQueryResponse>>
    {
        readonly IAchievementCategoryRepository _achievementCategoryRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetAchievementCategoryPagedListQueryResponse>> Handle(GetAchievementCategoryPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _achievementCategoryRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetAchievementCategoryPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetAchievementCategoryPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetAchievementCategoryPagedListQueryHandler(IAchievementCategoryRepository achievementCategoryRepository, IMapper mapper)
        {
            _achievementCategoryRepository = achievementCategoryRepository;
            _mapper = mapper;
        }
    }
}
