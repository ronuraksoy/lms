using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AnnouncementStudent.Queries.GetAnnouncementStudentPagedList
{
    public class GetAnnouncementStudentPagedListQueryHandler : IRequestHandler<GetAnnouncementStudentPagedListQueryRequest, IPagedDataResult<GetAnnouncementStudentPagedListQueryResponse>>
    {
        readonly IAnnouncementStudentRepository _announcementStudentRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetAnnouncementStudentPagedListQueryResponse>> Handle(GetAnnouncementStudentPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _announcementStudentRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetAnnouncementStudentPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetAnnouncementStudentPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetAnnouncementStudentPagedListQueryHandler(IAnnouncementStudentRepository announcementStudentRepository, IMapper mapper)
        {
            _announcementStudentRepository = announcementStudentRepository;
            _mapper = mapper;
        }
    }
}
