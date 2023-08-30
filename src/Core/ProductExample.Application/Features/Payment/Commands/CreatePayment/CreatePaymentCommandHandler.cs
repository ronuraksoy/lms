using AutoMapper;
using FluentValidation;
using Lms.Application.Features.Category.Commands.CreateCategory;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Payment.Commands.CreatePayment
{
    public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommandRequest, IDataResult>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreatePaymentCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePaymentCommandHandler(IUnitOfWork unitOfWork, IValidator<CreatePaymentCommandRequest> validator, IMapper mapper, IPaymentRepository paymentRepository)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
            _mapper = mapper;
            _paymentRepository = paymentRepository;
        }

        public Task<IDataResult> Handle(CreatePaymentCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
