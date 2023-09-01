using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionType.Queries.GetQuestionTypeById
{
    public class GetQuestionTypeByIdQueryHandler: IRequestHandler<GetQuestionTypeByIdQueryRequest, IDataResult<GetQuestionTypeByIdQueryResponse>>
    {
        readonly IQuestionTypeRepository _questionTypeRepository;
        IMapper _mapper;

        public GetQuestionTypeByIdQueryHandler(IMapper mapper, IQuestionTypeRepository questionTypeRepository)
        {
            _mapper = mapper;
            _questionTypeRepository = questionTypeRepository;
        }

        public async Task<IDataResult<GetQuestionTypeByIdQueryResponse>> Handle(GetQuestionTypeByIdQueryRequest request, CancellationToken cancellationToken)
        {

            var data = await _questionTypeRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetQuestionTypeByIdQueryResponse>(data);
            return new DataResult<GetQuestionTypeByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
