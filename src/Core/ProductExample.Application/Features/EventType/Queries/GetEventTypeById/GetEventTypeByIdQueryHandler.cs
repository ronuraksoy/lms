using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventType.Queries.GetEventTypeById
{
    public class GetEventTypeByIdQueryHandler : IRequestHandler<GetEventTypeByIdQueryRequest, IDataResult<GetEventTypeByIdQueryResponse>>
    {
        readonly IEventTypeRepository _eventTypeRepository;
        IMapper _mapper;
        public GetEventTypeByIdQueryHandler(IEventTypeRepository eventTypeRepository, IMapper mapper)
        {
            _eventTypeRepository = eventTypeRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetEventTypeByIdQueryResponse>> Handle(GetEventTypeByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventTypeRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetEventTypeByIdQueryResponse>(data);
            return new DataResult<GetEventTypeByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
