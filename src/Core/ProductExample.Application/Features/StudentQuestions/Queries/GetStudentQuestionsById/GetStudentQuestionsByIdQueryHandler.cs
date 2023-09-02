using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentQuestions.Queries.GetStudentQuestionsById
{
    public class GetStudentQuestionsByIdQueryHandler : IRequestHandler<GetStudentQuestionsByIdQueryRequest, IDataResult<GetStudentQuestionsByIdQueryResponse>>
    {
        readonly IStudentQuestionsRepository _studentQuestionsRepository;
        IMapper _mapper;
        public GetStudentQuestionsByIdQueryHandler(IStudentQuestionsRepository studentQuestionsRepository, IMapper mapper)
        {
            _studentQuestionsRepository = studentQuestionsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetStudentQuestionsByIdQueryResponse>> Handle(GetStudentQuestionsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentQuestionsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetStudentQuestionsByIdQueryResponse>(data);
            return new DataResult<GetStudentQuestionsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
