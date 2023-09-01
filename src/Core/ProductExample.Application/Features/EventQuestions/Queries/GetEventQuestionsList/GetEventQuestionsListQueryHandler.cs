using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventQuestions.Queries.GetEventQuestionsList
{
    public class GetEventQuestionsListQueryHandler : IRequestHandler<GetEventQuestionsListQueryRequest, IDataResult<IEnumerable<GetEventQuestionsListQueryResponse>>>
    {
        readonly IEventQuestionsRepository _eventQuestionsRepository;
        IMapper _mapper;
        public GetEventQuestionsListQueryHandler(IEventQuestionsRepository eventQuestionsRepository, IMapper mapper)
        {
            _eventQuestionsRepository = eventQuestionsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetEventQuestionsListQueryResponse>>> Handle(GetEventQuestionsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventQuestionsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetEventQuestionsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetEventQuestionsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
