using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Exams.Queries.GetExamsById
{
    public class GetExamsByIdQueryHandler : IRequestHandler<GetExamsByIdQueryRequest, IDataResult<GetExamsByIdQueryResponse>>
    {
        readonly IExamsRepository _examsRepository;
        IMapper _mapper;
        public GetExamsByIdQueryHandler(IExamsRepository examsRepository, IMapper mapper)
        {
            _examsRepository = examsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetExamsByIdQueryResponse>> Handle(GetExamsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _examsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetExamsByIdQueryResponse>(data);
            return new DataResult<GetExamsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
