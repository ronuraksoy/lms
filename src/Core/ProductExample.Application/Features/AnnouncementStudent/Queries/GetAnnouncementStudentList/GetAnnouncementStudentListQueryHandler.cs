using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AnnouncementStudent.Queries.GetAnnouncementStudentList
{
    public class GetAnnouncementStudentListQueryHandler : IRequestHandler<GetAnnouncementStudentListQueryRequest, IDataResult<IEnumerable<GetAnnouncementStudentListQueryResponse>>>
    {
        readonly IAnnouncementStudentRepository _announcementStudentRepository;
        IMapper _mapper;
        public GetAnnouncementStudentListQueryHandler(IAnnouncementStudentRepository announcementStudentRepository, IMapper mapper)
        {
            _announcementStudentRepository = announcementStudentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetAnnouncementStudentListQueryResponse>>> Handle(GetAnnouncementStudentListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _announcementStudentRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetAnnouncementStudentListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetAnnouncementStudentListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
