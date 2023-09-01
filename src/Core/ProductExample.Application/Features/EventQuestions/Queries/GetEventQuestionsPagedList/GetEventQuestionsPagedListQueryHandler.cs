using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventQuestions.Queries.GetEventQuestionsPagedList
{
    public class GetEventQuestionsPagedListQueryHandler : IRequestHandler<GetEventQuestionsPagedListQueryRequest, IPagedDataResult<GetEventQuestionsPagedListQueryResponse>>
    {
        readonly IEventQuestionsRepository _eventQuestionsRepository;
        IMapper _mapper;
        public GetEventQuestionsPagedListQueryHandler(IEventQuestionsRepository eventQuestionsRepository, IMapper mapper)
        {
            _eventQuestionsRepository = eventQuestionsRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetEventQuestionsPagedListQueryResponse>> Handle(GetEventQuestionsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventQuestionsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetEventQuestionsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetEventQuestionsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
