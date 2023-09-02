using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentExamLogs.Commands.CreateStudentExamLogs
{
    public class CreateStudentExamLogsCommandHandler : IRequestHandler<CreateStudentExamLogsCommandRequest, IDataResult>
    {
        private readonly IStudentExamLogsRepository _studentExamLogsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateStudentExamLogsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStudentExamLogsCommandHandler(IStudentExamLogsRepository studentExamLogsRepository, IMapper mapper, IValidator<CreateStudentExamLogsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _studentExamLogsRepository = studentExamLogsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateStudentExamLogsCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
