using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAnswers.Queries.GetStudentAnswersList
{
    public class GetStudentAnswersListQueryHandler : IRequestHandler<GetStudentAnswersListQueryRequest, IDataResult<IEnumerable<GetStudentAnswersListQueryResponse>>>
    {
        readonly IStudentAnswersRepository _studentAnswersRepository;
        IMapper _mapper;
        public GetStudentAnswersListQueryHandler(IStudentAnswersRepository studentAnswersRepository, IMapper mapper)
        {
            _studentAnswersRepository = studentAnswersRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetStudentAnswersListQueryResponse>>> Handle(GetStudentAnswersListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentAnswersRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetStudentAnswersListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetStudentAnswersListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
