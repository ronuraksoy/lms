using AutoMapper;
using Lms.Application.Features.Announcement.Queries.GetAnnouncementPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ForumContent.Queries.GetForumContentPagedList
{
    public class GetForumContentPagedListQueryHandler : IRequestHandler<GetForumContentPagedListQueryRequest, IPagedDataResult<GetForumContentPagedListQueryResponse>>
    {
        readonly IForumContentRepository _forumContentRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetForumContentPagedListQueryResponse>> Handle(GetForumContentPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _forumContentRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetForumContentPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetForumContentPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetForumContentPagedListQueryHandler(IForumContentRepository forumContentRepository, IMapper mapper)
        {
            _forumContentRepository = forumContentRepository;
            _mapper = mapper;
        }
    }
}
