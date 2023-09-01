using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQueryRequest, IDataResult<IEnumerable<GetEventsListQueryResponse>>>
    {
        readonly IEventsRepository _eventsRepository;
        IMapper _mapper;
        public GetEventsListQueryHandler(IEventsRepository eventsRepository, IMapper mapper)
        {
            _eventsRepository = eventsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetEventsListQueryResponse>>> Handle(GetEventsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetEventsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetEventsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
