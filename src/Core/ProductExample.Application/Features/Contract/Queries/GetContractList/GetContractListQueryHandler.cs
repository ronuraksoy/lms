using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Contract.Queries.GetContractList
{
    public class GetContractListQueryHandler : IRequestHandler<GetContractListQueryRequest, IDataResult<IEnumerable<GetContractListQueryResponse>>>
    {
        readonly IContractRepository _contractRepository;
        IMapper _mapper;
        public GetContractListQueryHandler(IContractRepository contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetContractListQueryResponse>>> Handle(GetContractListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _contractRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetContractListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetContractListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
