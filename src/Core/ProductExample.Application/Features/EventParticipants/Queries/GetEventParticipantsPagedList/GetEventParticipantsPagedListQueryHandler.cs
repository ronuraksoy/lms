using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventParticipants.Queries.GetEventParticipantsPagedList
{
    public class GetEventParticipantsPagedListQueryHandler : IRequestHandler<GetEventParticipantsPagedListQueryRequest, IPagedDataResult<GetEventParticipantsPagedListQueryResponse>>
    {
        readonly IEventParticipantsRepository _eventParticipantsRepository;
        IMapper _mapper;
        public GetEventParticipantsPagedListQueryHandler(IEventParticipantsRepository eventParticipantsRepository, IMapper mapper)
        {
            _eventParticipantsRepository = eventParticipantsRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetEventParticipantsPagedListQueryResponse>> Handle(GetEventParticipantsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventParticipantsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetEventParticipantsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetEventParticipantsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
