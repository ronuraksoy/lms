using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentExamLogs.Queries.GetStudentExamLogsList
{
    public class GetStudentExamLogsListQueryHandler : IRequestHandler<GetStudentExamLogsListQueryRequest, IDataResult<IEnumerable<GetStudentExamLogsListQueryResponse>>>
    {
        readonly IStudentExamLogsRepository _studentExamLogsRepository;
        IMapper _mapper;
        public GetStudentExamLogsListQueryHandler(IStudentExamLogsRepository studentExamLogsRepository, IMapper mapper)
        {
            _studentExamLogsRepository = studentExamLogsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetStudentExamLogsListQueryResponse>>> Handle(GetStudentExamLogsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentExamLogsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetStudentExamLogsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetStudentExamLogsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
