using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetTeacherPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Announcement.Queries.GetAnnouncementPagedList
{
    public class GetAnnouncementPagedListQueryHandler : IRequestHandler<GetAnnouncementPagedListQueryRequest, IPagedDataResult<GetAnnouncementPagedListQueryResponse>>
    {
        readonly IAnnouncementRepository _announcementRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetAnnouncementPagedListQueryResponse>> Handle(GetAnnouncementPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _announcementRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetAnnouncementPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetAnnouncementPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetAnnouncementPagedListQueryHandler(IAnnouncementRepository AnnouncementRepository, IMapper mapper)
        {
            _announcementRepository = AnnouncementRepository;
            _mapper = mapper;
        }
    }
}
