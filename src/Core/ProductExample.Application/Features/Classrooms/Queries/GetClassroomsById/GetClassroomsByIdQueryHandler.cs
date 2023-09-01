using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Classrooms.Queries.GetClassroomsById
{
    public class GetClassroomsByIdQueryHandler : IRequestHandler<GetClassroomsByIdQueryRequest, IDataResult<GetClassroomsByIdQueryResponse>>
    {
        readonly IClassroomsRepository _classroomsRepository;
        IMapper _mapper;
        public GetClassroomsByIdQueryHandler(IClassroomsRepository classroomsRepository, IMapper mapper)
        {
            _classroomsRepository = classroomsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetClassroomsByIdQueryResponse>> Handle(GetClassroomsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _classroomsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetClassroomsByIdQueryResponse>(data);
            return new DataResult<GetClassroomsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
