using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Contract.Queries.GetContractById
{
    public class GetContractByIdQueryHandler : IRequestHandler<GetContractByIdQueryRequest, IDataResult<GetContractByIdQueryResponse>>
    {
        readonly IContractRepository _contractRepository;
        IMapper _mapper;
        public GetContractByIdQueryHandler(IContractRepository contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetContractByIdQueryResponse>> Handle(GetContractByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _contractRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetContractByIdQueryResponse>(data);
            return new DataResult<GetContractByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
