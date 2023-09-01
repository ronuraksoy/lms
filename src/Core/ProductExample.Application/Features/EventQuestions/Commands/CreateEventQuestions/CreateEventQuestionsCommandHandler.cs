using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventQuestions.Commands.CreateEventQuestions
{
    public class CreateEventQuestionsCommandHandler : IRequestHandler<CreateEventQuestionsCommandRequest, IDataResult>
    {
        private readonly IEventQuestionsRepository _eventQuestionsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateEventQuestionsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEventQuestionsCommandHandler(IEventQuestionsRepository eventQuestionsRepository, IMapper mapper, IValidator<CreateEventQuestionsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _eventQuestionsRepository = eventQuestionsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateEventQuestionsCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
