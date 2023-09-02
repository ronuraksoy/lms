using AutoMapper;
using Lms.Application.Features.Announcement.Queries.GetAnnouncementPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ForumCategory.Queries.GetForumCategoryPagedList
{
    public class GetForumCategoryPagedListQueryHandler : IRequestHandler<GetForumCategoryPagedListQueryRequest, IPagedDataResult<GetForumCategoryPagedListQueryResponse>>
    {
        readonly IForumCategoryRepository _forumCategoryRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetForumCategoryPagedListQueryResponse>> Handle(GetForumCategoryPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _forumCategoryRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetForumCategoryPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetForumCategoryPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetForumCategoryPagedListQueryHandler(IForumCategoryRepository forumCategoryRepository, IMapper mapper)
        {
            _forumCategoryRepository = forumCategoryRepository;
            _mapper = mapper;
        }
    }
}
