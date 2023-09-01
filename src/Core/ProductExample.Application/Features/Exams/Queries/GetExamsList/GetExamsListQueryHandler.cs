using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Exams.Queries.GetExamsList
{
    public class GetExamsListQueryHandler : IRequestHandler<GetExamsListQueryRequest, IDataResult<IEnumerable<GetExamsListQueryResponse>>>
    {
        readonly IExamsRepository _examsRepository;
        IMapper _mapper;
        public GetExamsListQueryHandler(IExamsRepository examsRepository, IMapper mapper)
        {
            _examsRepository = examsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetExamsListQueryResponse>>> Handle(GetExamsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _examsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetExamsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetExamsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
