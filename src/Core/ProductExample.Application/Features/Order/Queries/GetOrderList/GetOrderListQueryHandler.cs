using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Order.Queries.GetOrderList
{
    public class GetOrderListQueryHandler : IRequestHandler<GetOrderListQueryRequest, IDataResult<IEnumerable<GetOrderListQueryResponse>>>
    {
        readonly IOrderRepository _orderRepository;
        IMapper _mapper;
        public GetOrderListQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetOrderListQueryResponse>>> Handle(GetOrderListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _orderRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetOrderListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetOrderListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
