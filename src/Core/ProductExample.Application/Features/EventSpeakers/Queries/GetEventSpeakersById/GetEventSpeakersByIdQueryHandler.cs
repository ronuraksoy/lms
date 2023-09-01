using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventSpeakers.Queries.GetEventSpeakersById
{
    public class GetEventSpeakersByIdQueryHandler : IRequestHandler<GetEventSpeakersByIdQueryRequest, IDataResult<GetEventSpeakersByIdQueryResponse>>
    {
        readonly IEventSpeakersRepository _eventSpeakersRepository;
        IMapper _mapper;
        public GetEventSpeakersByIdQueryHandler(IEventSpeakersRepository eventSpeakersRepository, IMapper mapper)
        {
            _eventSpeakersRepository = eventSpeakersRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetEventSpeakersByIdQueryResponse>> Handle(GetEventSpeakersByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventSpeakersRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetEventSpeakersByIdQueryResponse>(data);
            return new DataResult<GetEventSpeakersByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
