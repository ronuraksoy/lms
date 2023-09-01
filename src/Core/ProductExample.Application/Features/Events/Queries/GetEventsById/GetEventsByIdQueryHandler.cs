using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Events.Queries.GetEventsById
{
    public class GetEventsByIdQueryHandler : IRequestHandler<GetEventsByIdQueryRequest, IDataResult<GetEventsByIdQueryResponse>>
    {
        readonly IEventsRepository _eventsRepository;
        IMapper _mapper;
        public GetEventsByIdQueryHandler(IEventsRepository eventsRepository, IMapper mapper)
        {
            _eventsRepository = eventsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetEventsByIdQueryResponse>> Handle(GetEventsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetEventsByIdQueryResponse>(data);
            return new DataResult<GetEventsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
