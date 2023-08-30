using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ValidAnswers.Commands.CreateValidAnswers
{
    public class CreateValidAnswersCommandHandler : IRequestHandler<CreateValidAnswersCommandRequest, IDataResult>
    {
        private readonly IValidAnswersRepository _validAnswersRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateValidAnswersCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateValidAnswersCommandHandler(IValidAnswersRepository validAnswersRepository, IMapper mapper, IValidator<CreateValidAnswersCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _validAnswersRepository = validAnswersRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateValidAnswersCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
