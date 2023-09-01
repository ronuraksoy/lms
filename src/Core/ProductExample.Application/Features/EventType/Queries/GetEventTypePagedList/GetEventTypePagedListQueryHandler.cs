using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventType.Queries.GetEventTypePagedList
{
    public class GetEventTypePagedListQueryHandler : IRequestHandler<GetEventTypePagedListQueryRequest, IPagedDataResult<GetEventTypePagedListQueryResponse>>
    {
        readonly IEventTypeRepository _eventTypeRepository;
        IMapper _mapper;
        public GetEventTypePagedListQueryHandler(IEventTypeRepository eventTypeRepository, IMapper mapper)
        {
            _eventTypeRepository = eventTypeRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetEventTypePagedListQueryResponse>> Handle(GetEventTypePagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventTypeRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetEventTypePagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetEventTypePagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
