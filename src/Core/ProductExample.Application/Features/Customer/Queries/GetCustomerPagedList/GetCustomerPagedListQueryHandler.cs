using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Customer.Queries.GetCustomerPagedList
{
    public class GetCustomerPagedListQueryHandler : IRequestHandler<GetCustomerPagedListQueryRequest, IPagedDataResult<GetCustomerPagedListQueryResponse>>
    {
        readonly ICustomerRepository _customerRepository;
        IMapper _mapper;
        public GetCustomerPagedListQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetCustomerPagedListQueryResponse>> Handle(GetCustomerPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _customerRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetCustomerPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetCustomerPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
