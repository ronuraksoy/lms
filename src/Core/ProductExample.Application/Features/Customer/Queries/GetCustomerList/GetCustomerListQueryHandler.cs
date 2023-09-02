using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Customer.Queries.GetCustomerList
{
    public class GetCustomerListQueryHandler : IRequestHandler<GetCustomerListQueryRequest, IDataResult<IEnumerable<GetCustomerListQueryResponse>>>
    {
        readonly ICustomerRepository _customerRepository;
        IMapper _mapper;
        public GetCustomerListQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetCustomerListQueryResponse>>> Handle(GetCustomerListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _customerRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetCustomerListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetCustomerListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
