using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAnswers.Queries.GetStudentAnswersById
{
    public class GetStudentAnswersByIdQueryHandler : IRequestHandler<GetStudentAnswersByIdQueryRequest, IDataResult<GetStudentAnswersByIdQueryResponse>>
    {
        readonly IStudentAnswersRepository _studentAnswersRepository;
        IMapper _mapper;
        public GetStudentAnswersByIdQueryHandler(IStudentAnswersRepository studentAnswersRepository, IMapper mapper)
        {
            _studentAnswersRepository = studentAnswersRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetStudentAnswersByIdQueryResponse>> Handle(GetStudentAnswersByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentAnswersRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetStudentAnswersByIdQueryResponse>(data);
            return new DataResult<GetStudentAnswersByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
