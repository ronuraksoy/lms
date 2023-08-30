using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ValidAnswers.Queries.GetValidAnswersById
{
    public class GetValidAnswersByIdQueryHandler : IRequestHandler<GetValidAnswersByIdQueryRequest, IDataResult<GetValidAnswersByIdQueryResponse>>
    {
        readonly IValidAnswersRepository _validAnswersRepository;
        IMapper _mapper;
        public GetValidAnswersByIdQueryHandler(IValidAnswersRepository validAnswersRepository, IMapper mapper)
        {
            _validAnswersRepository = validAnswersRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetValidAnswersByIdQueryResponse>> Handle(GetValidAnswersByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _validAnswersRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetValidAnswersByIdQueryResponse>(data);
            return new DataResult<GetValidAnswersByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
