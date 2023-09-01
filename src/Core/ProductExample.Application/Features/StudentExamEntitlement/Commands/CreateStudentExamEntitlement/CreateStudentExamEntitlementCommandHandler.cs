using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentExamEntitlement.Commands.CreateStudentExamEntitlement
{
    public class CreateStudentExamEntitlementCommandHandler : IRequestHandler<CreateStudentExamEntitlementCommandRequest, IDataResult>
    {
        private readonly IStudentExamEntitlementRepository _studentExamEntitlementRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateStudentExamEntitlementCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStudentExamEntitlementCommandHandler(IStudentExamEntitlementRepository studentExamEntitlementRepository, IMapper mapper, IValidator<CreateStudentExamEntitlementCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _studentExamEntitlementRepository = studentExamEntitlementRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateStudentExamEntitlementCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
