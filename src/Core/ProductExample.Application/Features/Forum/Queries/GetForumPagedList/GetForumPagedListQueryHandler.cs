using AutoMapper;
using Lms.Application.Features.Announcement.Queries.GetAnnouncementPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Forum.Queries.GetForumPagedList
{
    public class GetForumPagedListQueryHandler : IRequestHandler<GetForumPagedListQueryRequest, IPagedDataResult<GetForumPagedListQueryResponse>>
    {
        readonly IForumRepository _forumRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetForumPagedListQueryResponse>> Handle(GetForumPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _forumRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetForumPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetForumPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetForumPagedListQueryHandler(IForumRepository forumRepository, IMapper mapper)
        {
            _forumRepository = forumRepository;
            _mapper = mapper;
        }
    }
}
