using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionType.Queries.GetQuestionTypeList
{
    public class GetQuestionTypeListQueryHandler : IRequestHandler<GetQuestionTypeListQueryRequest, IDataResult<IEnumerable<GetQuestionTypeListQueryResponse>>>
    {
        readonly IQuestionTypeRepository _questionTypeRepository;
        IMapper _mapper;

        public GetQuestionTypeListQueryHandler(IMapper mapper, IQuestionTypeRepository questionTypeRepository)
        {
            _mapper = mapper;
            _questionTypeRepository = questionTypeRepository;
        }

        public async Task<IDataResult<IEnumerable<GetQuestionTypeListQueryResponse>>> Handle(GetQuestionTypeListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _questionTypeRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetQuestionTypeListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetQuestionTypeListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
