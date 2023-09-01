using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ExamsQuestions.Queries.GetExamsQuestionsList
{
    public class GetExamsQuestionsListQueryHandler : IRequestHandler<GetExamsQuestionsListQueryRequest, IDataResult<IEnumerable<GetExamsQuestionsListQueryResponse>>>
    {
        readonly IExamsQuestionsRepository _examsQuestionsRepository;
        IMapper _mapper;
        public GetExamsQuestionsListQueryHandler(IExamsQuestionsRepository examsQuestionsRepository, IMapper mapper)
        {
            _examsQuestionsRepository = examsQuestionsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetExamsQuestionsListQueryResponse>>> Handle(GetExamsQuestionsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _examsQuestionsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetExamsQuestionsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetExamsQuestionsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
