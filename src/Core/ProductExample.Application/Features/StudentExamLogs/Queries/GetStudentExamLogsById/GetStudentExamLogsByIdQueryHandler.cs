using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentExamLogs.Queries.GetStudentExamLogsById
{
    public class GetStudentExamLogsByIdQueryHandler : IRequestHandler<GetStudentExamLogsByIdQueryRequest, IDataResult<GetStudentExamLogsByIdQueryResponse>>
    {
        readonly IStudentExamLogsRepository _studentExamLogsRepository;
        IMapper _mapper;
        public GetStudentExamLogsByIdQueryHandler(IStudentExamLogsRepository studentExamLogsRepository, IMapper mapper)
        {
            _studentExamLogsRepository = studentExamLogsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetStudentExamLogsByIdQueryResponse>> Handle(GetStudentExamLogsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentExamLogsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetStudentExamLogsByIdQueryResponse>(data);
            return new DataResult<GetStudentExamLogsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
