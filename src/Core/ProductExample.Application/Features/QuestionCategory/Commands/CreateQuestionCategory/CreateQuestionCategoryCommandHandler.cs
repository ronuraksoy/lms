using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionCategory.Commands.CreateQuestionCategory
{
    public class CreateQuestionCategoryCommandHandler:IRequestHandler<CreateQuestionCategoryCommandRequest,IDataResult>
    {

        private readonly IQuestionCategoryRepository _questionCategoryRepository;
        private readonly IValidator<CreateQuestionCategoryCommandRequest> _validator;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateQuestionCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IQuestionCategoryRepository questionCategoryRepository, IValidator<CreateQuestionCategoryCommandRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _questionCategoryRepository = questionCategoryRepository;
            _validator = validator;
        }

        public Task<IDataResult> Handle(CreateQuestionCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
