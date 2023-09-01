using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AnnouncementStudent.Queries.GetAnnouncementStudentById
{
    public class GetAnnouncementStudentByIdQueryHandler : IRequestHandler<GetAnnouncementStudentByIdQueryRequest, IDataResult<GetAnnouncementStudentByIdQueryResponse>>
    {
        readonly IAnnouncementStudentRepository _announcementStudentRepository;
        IMapper _mapper;
        public GetAnnouncementStudentByIdQueryHandler(IAnnouncementStudentRepository announcementStudentRepository, IMapper mapper)
        {
            _announcementStudentRepository = announcementStudentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetAnnouncementStudentByIdQueryResponse>> Handle(GetAnnouncementStudentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _announcementStudentRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetAnnouncementStudentByIdQueryResponse>(data);
            return new DataResult<GetAnnouncementStudentByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
