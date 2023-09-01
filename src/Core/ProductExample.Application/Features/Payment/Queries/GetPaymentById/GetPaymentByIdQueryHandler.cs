using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Payment.Queries.GetPaymentById
{
    internal class GetPaymentByIdQueryHandler : IRequestHandler<GetPaymentByIdQueryRequest, IDataResult<GetPaymentByIdQueryResponse>>
    {
        readonly IPaymentRepository _paymentRepository;
        IMapper _mapper;

        public GetPaymentByIdQueryHandler(IMapper mapper, IPaymentRepository paymentRepository)
        {
            _mapper = mapper;
            _paymentRepository = paymentRepository;
        }

        public async Task<IDataResult<GetPaymentByIdQueryResponse>> Handle(GetPaymentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _paymentRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetPaymentByIdQueryResponse>(data);
            return new DataResult<GetPaymentByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
