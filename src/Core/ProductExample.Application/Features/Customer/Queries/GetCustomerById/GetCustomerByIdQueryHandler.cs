using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Customer.Queries.GetCustomerById
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQueryRequest, IDataResult<GetCustomerByIdQueryResponse>>
    {
        readonly ICustomerRepository _customerRepository;
        IMapper _mapper;
        public GetCustomerByIdQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetCustomerByIdQueryResponse>> Handle(GetCustomerByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _customerRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetCustomerByIdQueryResponse>(data);
            return new DataResult<GetCustomerByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
