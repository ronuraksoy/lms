using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventType.Queries.GetEventTypeList
{
    public class GetEventTypeListQueryHandler : IRequestHandler<GetEventTypeListQueryRequest, IDataResult<IEnumerable<GetEventTypeListQueryResponse>>>
    {
        readonly IEventTypeRepository _eventTypeRepository;
        IMapper _mapper;
        public GetEventTypeListQueryHandler(IEventTypeRepository eventTypeRepository, IMapper mapper)
        {
            _eventTypeRepository = eventTypeRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetEventTypeListQueryResponse>>> Handle(GetEventTypeListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventTypeRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetEventTypeListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetEventTypeListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
