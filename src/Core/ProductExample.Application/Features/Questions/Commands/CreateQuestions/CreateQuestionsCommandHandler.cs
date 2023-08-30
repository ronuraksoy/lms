using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Questions.Commands.CreateQuestions
{
    public class CreateQuestionsCommandHandler:IRequestHandler<CreateQuestionsCommandRequest,IDataResult>
    {

        private readonly IQuestionsRepository _questionsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateQuestionsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateQuestionsCommandHandler(IUnitOfWork unitOfWork, IValidator<CreateQuestionsCommandRequest> validator, IMapper mapper, IQuestionsRepository questionsRepository)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
            _mapper = mapper;
            _questionsRepository = questionsRepository;
        }

        public Task<IDataResult> Handle(CreateQuestionsCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
