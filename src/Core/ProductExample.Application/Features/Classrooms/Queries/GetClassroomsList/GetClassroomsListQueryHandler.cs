using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Classrooms.Queries.GetClassroomsList
{
    public class GetClassroomsListQueryHandler : IRequestHandler<GetClassroomsListQueryRequest, IDataResult<IEnumerable<GetClassroomsListQueryResponse>>>
    {
        readonly IClassroomsRepository _classroomsRepository;
        IMapper _mapper;
        public GetClassroomsListQueryHandler(IClassroomsRepository classroomsRepository, IMapper mapper)
        {
            _classroomsRepository = classroomsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetClassroomsListQueryResponse>>> Handle(GetClassroomsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _classroomsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetClassroomsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetClassroomsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
