using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Payment.Queries.GetPaymentPagedList
{
    public class GetPaymentPagedListQueryHandler: IRequestHandler<GetPaymentPagedListQueryRequest, IPagedDataResult<GetPaymentPagedListQueryResponse>>
    {
        readonly IPaymentRepository _paymentRepository;
        IMapper _mapper;

        public GetPaymentPagedListQueryHandler(IMapper mapper, IPaymentRepository paymentRepository)
        {
            _mapper = mapper;
            _paymentRepository = paymentRepository;
        }

        public Task<IPagedDataResult<GetPaymentPagedListQueryResponse>> Handle(GetPaymentPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
