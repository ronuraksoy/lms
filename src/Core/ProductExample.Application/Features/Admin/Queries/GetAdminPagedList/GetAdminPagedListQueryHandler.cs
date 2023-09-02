using AutoMapper;
using Lms.Application.Features.Announcement.Queries.GetAnnouncementPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Admin.Queries.GetAdminPagedList
{
    public class GetAdminPagedListQueryHandler : IRequestHandler<GetAdminPagedListQueryRequest, IPagedDataResult<GetAdminPagedListQueryResponse>>
    {
        readonly IAdminRepository _adminRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetAdminPagedListQueryResponse>> Handle(GetAdminPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _adminRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetAdminPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetAdminPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetAdminPagedListQueryHandler(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }
    }
}
