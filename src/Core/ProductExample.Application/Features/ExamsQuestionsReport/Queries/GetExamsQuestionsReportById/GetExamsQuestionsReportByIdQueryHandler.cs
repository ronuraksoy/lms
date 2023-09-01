using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ExamsQuestionsReport.Queries.GetExamsQuestionsReportById
{
    public class GetExamsQuestionsByIdQueryHandler : IRequestHandler<GetExamsQuestionsByIdQueryRequest, IDataResult<GetExamsQuestionsByIdQueryResponse>>
    {
        readonly IExamsQuestionsReportRepository _examsQuestionsReportRepository;
        IMapper _mapper;
        public GetExamsQuestionsByIdQueryHandler(IExamsQuestionsReportRepository examsQuestionsReportRepository, IMapper mapper)
        {
            _examsQuestionsReportRepository = examsQuestionsReportRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetExamsQuestionsByIdQueryResponse>> Handle(GetExamsQuestionsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _examsQuestionsReportRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetExamsQuestionsByIdQueryResponse>(data);
            return new DataResult<GetExamsQuestionsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
