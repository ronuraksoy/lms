using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventParticipantsAnswer.Queries.GetEventParticipantsAnswerList
{
    public class GetEventParticipantsAnswerListQueryHandler : IRequestHandler<GetEventParticipantsAnswerListQueryRequest, IDataResult<IEnumerable<GetEventParticipantsAnswerListQueryResponse>>>
    {
        readonly IEventParticipantsAnswerRepository _EventParticipantsAnswerRepository;
        IMapper _mapper;
        public GetEventParticipantsAnswerListQueryHandler(IEventParticipantsAnswerRepository EventParticipantsAnswerRepository, IMapper mapper)
        {
            _EventParticipantsAnswerRepository = EventParticipantsAnswerRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetEventParticipantsAnswerListQueryResponse>>> Handle(GetEventParticipantsAnswerListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _EventParticipantsAnswerRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetEventParticipantsAnswerListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetEventParticipantsAnswerListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
