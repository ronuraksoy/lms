using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Questions.Queries.GetQuestionList
{
    public class GetQuestionListQueryHandler : IRequestHandler<GetQuestionsListQueryRequest, IDataResult<IEnumerable<GetQuestionsListQueryResponse>>>
    {
        readonly IQuestionsRepository _questionsRepository;
        IMapper _mapper;

        public GetQuestionListQueryHandler(IMapper mapper, IQuestionsRepository questionsRepository)
        {
            _mapper = mapper;
            _questionsRepository = questionsRepository;
        }

        public async Task<IDataResult<IEnumerable<GetQuestionsListQueryResponse>>> Handle(GetQuestionsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _questionsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetQuestionsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetQuestionsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
