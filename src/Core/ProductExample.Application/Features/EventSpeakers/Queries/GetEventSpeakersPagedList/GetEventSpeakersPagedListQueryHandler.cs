using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventSpeakers.Queries.GetEventSpeakersPagedList
{
    public class GetEventSpeakersPagedListQueryHandler : IRequestHandler<GetEventSpeakersPagedListQueryRequest, IPagedDataResult<GetEventSpeakersPagedListQueryResponse>>
    {
        readonly IEventSpeakersRepository _eventSpeakersRepository;
        IMapper _mapper;
        public GetEventSpeakersPagedListQueryHandler(IEventSpeakersRepository eventSpeakersRepository, IMapper mapper)
        {
            _eventSpeakersRepository = eventSpeakersRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetEventSpeakersPagedListQueryResponse>> Handle(GetEventSpeakersPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventSpeakersRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetEventSpeakersPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetEventSpeakersPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
