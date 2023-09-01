using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentQuestions.Queries.GetStudentQuestionsList
{
    public class GetStudentQuestionsListQueryHandler : IRequestHandler<GetStudentQuestionsListQueryRequest, IDataResult<IEnumerable<GetStudentQuestionsListQueryResponse>>>
    {
        readonly IStudentQuestionsRepository _studentQuestionsRepository;
        IMapper _mapper;
        public GetStudentQuestionsListQueryHandler(IStudentQuestionsRepository studentQuestionsRepository, IMapper mapper)
        {
            _studentQuestionsRepository = studentQuestionsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetStudentQuestionsListQueryResponse>>> Handle(GetStudentQuestionsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentQuestionsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetStudentQuestionsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetStudentQuestionsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
