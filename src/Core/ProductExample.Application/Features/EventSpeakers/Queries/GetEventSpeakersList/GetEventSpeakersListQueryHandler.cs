using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventSpeakers.Queries.GetEventSpeakersList
{
    public class GetEventSpeakersListQueryHandler : IRequestHandler<GetEventSpeakersListQueryRequest, IDataResult<IEnumerable<GetEventSpeakersListQueryResponse>>>
    {
        readonly IEventSpeakersRepository _eventSpeakersRepository;
        IMapper _mapper;
        public GetEventSpeakersListQueryHandler(IEventSpeakersRepository eventSpeakersRepository, IMapper mapper)
        {
            _eventSpeakersRepository = eventSpeakersRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetEventSpeakersListQueryResponse>>> Handle(GetEventSpeakersListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventSpeakersRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetEventSpeakersListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetEventSpeakersListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
