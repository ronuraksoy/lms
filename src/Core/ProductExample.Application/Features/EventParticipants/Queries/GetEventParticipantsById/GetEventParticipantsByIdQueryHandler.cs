using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventParticipants.Queries.GetEventParticipantsById
{
    public class GetEventParticipantsByIdQueryHandler : IRequestHandler<GetEventParticipantsByIdQueryRequest, IDataResult<GetEventParticipantsByIdQueryResponse>>
    {
        readonly IEventParticipantsRepository _eventParticipantsRepository;
        IMapper _mapper;
        public GetEventParticipantsByIdQueryHandler(IEventParticipantsRepository eventParticipantsRepository, IMapper mapper)
        {
            _eventParticipantsRepository = eventParticipantsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetEventParticipantsByIdQueryResponse>> Handle(GetEventParticipantsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventParticipantsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetEventParticipantsByIdQueryResponse>(data);
            return new DataResult<GetEventParticipantsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
