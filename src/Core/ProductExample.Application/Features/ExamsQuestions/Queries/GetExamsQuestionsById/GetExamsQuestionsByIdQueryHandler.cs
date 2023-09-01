using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ExamsQuestions.Queries.GetExamsQuestionsById
{
    public class GetExamsQuestionsByIdQueryHandler : IRequestHandler<GetExamsQuestionsByIdQueryRequest, IDataResult<GetExamsQuestionsByIdQueryResponse>>
    {
        readonly IExamsQuestionsRepository _examsQuestionsRepository;
        IMapper _mapper;
        public GetExamsQuestionsByIdQueryHandler(IExamsQuestionsRepository examsQuestionsRepository, IMapper mapper)
        {
            _examsQuestionsRepository = examsQuestionsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetExamsQuestionsByIdQueryResponse>> Handle(GetExamsQuestionsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _examsQuestionsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetExamsQuestionsByIdQueryResponse>(data);
            return new DataResult<GetExamsQuestionsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
