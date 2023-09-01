using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Announcement.Queries.GetAnnouncementList
{
    public class GetAnnouncementListQueryHandler : IRequestHandler<GetAnnouncementListQueryRequest, IDataResult<IEnumerable<GetAnnouncementListQueryResponse>>>
    {
        readonly IAnnouncementRepository _announcementRepository;
        IMapper _mapper;
        public GetAnnouncementListQueryHandler(IAnnouncementRepository announcementRepository, IMapper mapper)
        {
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetAnnouncementListQueryResponse>>> Handle(GetAnnouncementListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _announcementRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetAnnouncementListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetAnnouncementListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
