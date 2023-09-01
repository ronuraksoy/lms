using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAnswers.Commands.CreateStudentAnswers
{
    public class CreateStudentAnswersCommandHandler : IRequestHandler<CreateStudentAnswersCommandRequest, IDataResult>
    {
        private readonly IStudentAnswersRepository _studentAnswersRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateStudentAnswersCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStudentAnswersCommandHandler(IStudentAnswersRepository studentAnswersRepository, IMapper mapper, IValidator<CreateStudentAnswersCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _studentAnswersRepository = studentAnswersRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateStudentAnswersCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
