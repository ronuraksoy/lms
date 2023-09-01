using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventParticipantsAnswer.Queries.GetEventParticipantsAnswerById
{
    public class GetEventParticipantsAnswerByIdQueryHandler : IRequestHandler<GetEventParticipantsAnswerByIdQueryRequest, IDataResult<GetEventParticipantsAnswerByIdQueryResponse>>
    {
        readonly IEventParticipantsAnswerRepository _eventParticipantsAnswerRepository;
        IMapper _mapper;
        public GetEventParticipantsAnswerByIdQueryHandler(IEventParticipantsAnswerRepository eventParticipantsAnswerRepository, IMapper mapper)
        {
            _eventParticipantsAnswerRepository = eventParticipantsAnswerRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetEventParticipantsAnswerByIdQueryResponse>> Handle(GetEventParticipantsAnswerByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventParticipantsAnswerRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetEventParticipantsAnswerByIdQueryResponse>(data);
            return new DataResult<GetEventParticipantsAnswerByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
