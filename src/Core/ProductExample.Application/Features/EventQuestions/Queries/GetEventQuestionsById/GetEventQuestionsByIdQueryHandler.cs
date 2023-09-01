using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventQuestions.Queries.GetEventQuestionsById
{
    public class GetEventQuestionsByIdQueryHandler : IRequestHandler<GetEventQuestionsByIdQueryRequest, IDataResult<GetEventQuestionsByIdQueryResponse>>
    {
        readonly IEventQuestionsRepository _eventQuestionsRepository;
        IMapper _mapper;
        public GetEventQuestionsByIdQueryHandler(IEventQuestionsRepository eventQuestionsRepository, IMapper mapper)
        {
            _eventQuestionsRepository = eventQuestionsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetEventQuestionsByIdQueryResponse>> Handle(GetEventQuestionsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _eventQuestionsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetEventQuestionsByIdQueryResponse>(data);
            return new DataResult<GetEventQuestionsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
