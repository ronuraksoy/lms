using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentQuestions.Commands.CreateStudentQuestions
{
    public class CreateStudentQuestionsCommandHandler : IRequestHandler<CreateStudentQuestionsCommandRequest, IDataResult>
    {
        private readonly IStudentQuestionsRepository _studentQuestionsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateStudentQuestionsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStudentQuestionsCommandHandler(IStudentQuestionsRepository studentQuestionsRepository, IMapper mapper, IValidator<CreateStudentQuestionsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _studentQuestionsRepository = studentQuestionsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateStudentQuestionsCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
