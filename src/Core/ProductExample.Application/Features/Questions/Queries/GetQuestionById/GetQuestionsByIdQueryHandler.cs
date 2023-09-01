using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Questions.Queries.GetQuestionById
{
    public class GetQuestionsByIdQueryHandler : IRequestHandler<GetQuestionsByIdQueryRequest, IDataResult<GetQuestionsByIdQueryResponse>>
    {
        readonly IQuestionsRepository _questionsRepository;
        IMapper _mapper;

        public GetQuestionsByIdQueryHandler(IMapper mapper, IQuestionsRepository questionsRepository)
        {
            _mapper = mapper;
            _questionsRepository = questionsRepository;
        }

        public async Task<IDataResult<GetQuestionsByIdQueryResponse>> Handle(GetQuestionsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _questionsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetQuestionsByIdQueryResponse>(data);
            return new DataResult<GetQuestionsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
