using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Contract.Queries.GetContractPagedList
{
    public class GetContractPagedListQueryHandler : IRequestHandler<GetContractPagedListQueryRequest, IPagedDataResult<GetContractPagedListQueryResponse>>
    {
        readonly IContractRepository _contractRepository;
        IMapper _mapper;
        public GetContractPagedListQueryHandler(IContractRepository contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetContractPagedListQueryResponse>> Handle(GetContractPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _contractRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetContractPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetContractPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
