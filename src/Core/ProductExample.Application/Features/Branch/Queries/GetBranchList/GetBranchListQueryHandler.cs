using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Branch.Queries.GetBranchList
{
    public class GetBranchListQueryHandler : IRequestHandler<GetBranchListQueryRequest, IDataResult<IEnumerable<GetBranchListQueryResponse>>>
    {
        readonly IBranchRepository _branchRepository;
        IMapper _mapper;
        public GetBranchListQueryHandler(IBranchRepository branchRepository, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetBranchListQueryResponse>>> Handle(GetBranchListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _branchRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetBranchListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetBranchListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
