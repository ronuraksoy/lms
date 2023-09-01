using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionType.Commands.CreateQuestionType
{
    public class CreateQuestionTypeCommandHandler : IRequestHandler<CreateQuestionTypeCommandRequest, IDataResult>
    {

        private readonly IQuestionTypeRepository _questionTypeRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateQuestionTypeCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateQuestionTypeCommandHandler(IUnitOfWork unitOfWork, IValidator<CreateQuestionTypeCommandRequest> validator, IMapper mapper, IQuestionTypeRepository questionTypeRepository)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
            _mapper = mapper;
            _questionTypeRepository = questionTypeRepository;
        }

        public Task<IDataResult> Handle(CreateQuestionTypeCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
