using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Branch.Queries.GetBranchById
{
    public class GetBranchByIdQueryHandler : IRequestHandler<GetBranchByIdQueryRequest, IDataResult<GetBranchByIdQueryResponse>>
    {
        readonly IBranchRepository _branchRepository;
        IMapper _mapper;
        public GetBranchByIdQueryHandler(IBranchRepository branchRepository, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetBranchByIdQueryResponse>> Handle(GetBranchByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _branchRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetBranchByIdQueryResponse>(data);
            return new DataResult<GetBranchByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
