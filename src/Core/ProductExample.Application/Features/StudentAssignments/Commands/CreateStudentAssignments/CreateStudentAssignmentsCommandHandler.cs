using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAssignments.Commands.CreateStudentAssignments
{
    public class CreateStudentAssignmentsCommandHandler : IRequestHandler<CreateStudentAssignmentsCommandRequest, IDataResult>
    {
        private readonly IStudentAssignmentsRepository _studentAssignmentsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateStudentAssignmentsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStudentAssignmentsCommandHandler(IStudentAssignmentsRepository studentAssignmentsRepository, IMapper mapper, IValidator<CreateStudentAssignmentsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _studentAssignmentsRepository = studentAssignmentsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateStudentAssignmentsCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
