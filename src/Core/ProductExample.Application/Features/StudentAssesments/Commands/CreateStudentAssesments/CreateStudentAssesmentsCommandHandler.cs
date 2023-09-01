using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAssesments.Commands.CreateStudentAssesments
{
    public class CreateStudentAssesmentsCommandHandler : IRequestHandler<CreateStudentAssesmentsCommandRequest, IDataResult>
    {
        private readonly IStudentAssesmentsRepository _studentAssesmentsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateStudentAssesmentsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStudentAssesmentsCommandHandler(IStudentAssesmentsRepository studentAssesmentsRepository, IMapper mapper, IValidator<CreateStudentAssesmentsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _studentAssesmentsRepository = studentAssesmentsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateStudentAssesmentsCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
