using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Branch.Queries.GetBranchPagedList
{
    public class GetBranchPagedListQueryHandler : IRequestHandler<GetBranchPagedListQueryRequest, IPagedDataResult<GetBranchPagedListQueryResponse>>
    {
        readonly IBranchRepository _branchRepository;
        IMapper _mapper;
        public GetBranchPagedListQueryHandler(IBranchRepository branchRepository, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetBranchPagedListQueryResponse>> Handle(GetBranchPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _branchRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetBranchPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetBranchPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
