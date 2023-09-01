using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Exams.Queries.GetExamsPagedList
{
    public class GetExamsPagedListQueryHandler : IRequestHandler<GetExamsPagedListQueryRequest, IPagedDataResult<GetExamsPagedListQueryResponse>>
    {
        readonly IExamsRepository _examsRepository;
        IMapper _mapper;
        public GetExamsPagedListQueryHandler(IExamsRepository examsRepository, IMapper mapper)
        {
            _examsRepository = examsRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetExamsPagedListQueryResponse>> Handle(GetExamsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _examsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetExamsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetExamsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
