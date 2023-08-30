using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ValidAnswers.Queries.GetValidAnswersList
{
    public class GetValidAnswersListQueryHandler : IRequestHandler<GetValidAnswersListQueryRequest, IDataResult<IEnumerable<GetValidAnswersListQueryResponse>>>
    {
        readonly IValidAnswersRepository _validAnswersRepository;
        IMapper _mapper;
        public GetValidAnswersListQueryHandler(IValidAnswersRepository validAnswersRepository, IMapper mapper)
        {
            _validAnswersRepository = validAnswersRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetValidAnswersListQueryResponse>>> Handle(GetValidAnswersListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _validAnswersRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetValidAnswersListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetValidAnswersListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
