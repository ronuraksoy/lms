using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Events.Queries.GetEventsPagedList
{
    public class GetEventsPagedListQueryHandler : IRequestHandler<GetEventsPagedListQueryRequest, IPagedDataResult<GetEventsPagedListQueryResponse>>
    {
        readonly IEventsRepository _eventsRepository;
        IMapper _mapper;
        public GetEventsPagedListQueryHandler(IEventsRepository eventsRepository, IMapper mapper)
        {
            _eventsRepository = eventsRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetEventsPagedListQueryResponse>> Handle(GetEventsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetEventsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetEventsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
