using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventParticipantsAnswer.Queries.GetEventParticipantsAnswerPagedList
{
    public class GetEventParticipantsAnswerPagedListQueryHandler : IRequestHandler<GetEventParticipantsAnswerPagedListQueryRequest, IPagedDataResult<GetEventParticipantsAnswerPagedListQueryResponse>>
    {
        readonly IEventParticipantsAnswerRepository _eventParticipantsAnswerRepository;
        IMapper _mapper;
        public GetEventParticipantsAnswerPagedListQueryHandler(IEventParticipantsAnswerRepository eventParticipantsAnswerRepository, IMapper mapper)
        {
            _eventParticipantsAnswerRepository = eventParticipantsAnswerRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetEventParticipantsAnswerPagedListQueryResponse>> Handle(GetEventParticipantsAnswerPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventParticipantsAnswerRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetEventParticipantsAnswerPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetEventParticipantsAnswerPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
