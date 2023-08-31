using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Payment.Queries.GetPaymentList
{
    public class GetPaymentListQueryHandler : IRequestHandler<GetPaymentListQueryRequest, IDataResult<IEnumerable<GetPaymentListQueryResponse>>>
    {
        readonly IPaymentRepository _paymentRepository;
        IMapper _mapper;
        public GetPaymentListQueryHandler(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<IEnumerable<GetPaymentListQueryResponse>>> Handle(GetPaymentListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _paymentRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetPaymentListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetPaymentListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
