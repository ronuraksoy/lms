using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AssignmentResult.Queries.GetAssignmentResultPagedList
{
    public class GetAssignmentResultPagedListQueryHandler : IRequestHandler<GetAssignmentResultPagedListQueryRequest, IPagedDataResult<GetAssignmentResultPagedListQueryResponse>>
    {
        readonly IAssignmentResultRepository _assignmentResultRepository;
        IMapper _mapper;
        public GetAssignmentResultPagedListQueryHandler(IAssignmentResultRepository assignmentResultRepository, IMapper mapper)
        {
            _assignmentResultRepository = assignmentResultRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetAssignmentResultPagedListQueryResponse>> Handle(GetAssignmentResultPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _assignmentResultRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetAssignmentResultPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetAssignmentResultPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
