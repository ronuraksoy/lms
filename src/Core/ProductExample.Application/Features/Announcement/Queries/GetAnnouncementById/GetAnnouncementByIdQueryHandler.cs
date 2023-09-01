using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Announcement.Queries.GetAnnouncementById
{
    public class GetAnnouncementByIdQueryHandler : IRequestHandler<GetAnnouncementByIdQueryRequest, IDataResult<GetAnnouncementByIdQueryResponse>>
    {
        readonly IAnnouncementRepository _announcementRepository;
        IMapper _mapper;
        public GetAnnouncementByIdQueryHandler(IAnnouncementRepository announcementRepository, IMapper mapper)
        {
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetAnnouncementByIdQueryResponse>> Handle(GetAnnouncementByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _announcementRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetAnnouncementByIdQueryResponse>(data);
            return new DataResult<GetAnnouncementByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
