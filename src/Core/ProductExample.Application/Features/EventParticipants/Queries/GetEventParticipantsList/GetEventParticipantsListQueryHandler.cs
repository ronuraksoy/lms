using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventParticipants.Queries.GetEventParticipantsList
{
    public class GetEventParticipantsListQueryHandler : IRequestHandler<GetEventParticipantsListQueryRequest, IDataResult<IEnumerable<GetEventParticipantsListQueryResponse>>>
    {
        readonly IEventParticipantsRepository _eventParticipantsRepository;
        IMapper _mapper;
        public GetEventParticipantsListQueryHandler(IEventParticipantsRepository eventParticipantsRepository, IMapper mapper)
        {
            _eventParticipantsRepository = eventParticipantsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetEventParticipantsListQueryResponse>>> Handle(GetEventParticipantsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventParticipantsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetEventParticipantsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetEventParticipantsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
