using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Semester.Queries.GetSemesterPagedList
{
    public class GetSemesterPagedListQueryHandler : IRequestHandler<GetSemesterPagedListQueryRequest, IPagedDataResult<GetSemesterPagedListQueryResponse>>
    {
        readonly ISemesterRepository _semesterRepository;
        IMapper _mapper;
        public GetSemesterPagedListQueryHandler(ISemesterRepository semesterRepository, IMapper mapper)
        {
            _semesterRepository = semesterRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetSemesterPagedListQueryResponse>> Handle(GetSemesterPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _semesterRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetSemesterPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetSemesterPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
