using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ExamsQuestionsReport.Queries.GetExamsQuestionsReportList
{
    public class GetExamsQuestionsListQueryHandler : IRequestHandler<GetExamsQuestionsListQueryRequest, IDataResult<IEnumerable<GetExamsQuestionsListQueryResponse>>>
    {
        readonly IExamsQuestionsReportRepository _examsQuestionsReportRepository;
        IMapper _mapper;
        public GetExamsQuestionsListQueryHandler(IExamsQuestionsReportRepository examsQuestionsReportRepository, IMapper mapper)
        {
            _examsQuestionsReportRepository = examsQuestionsReportRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetExamsQuestionsListQueryResponse>>> Handle(GetExamsQuestionsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _examsQuestionsReportRepository.GetListAsync();
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
