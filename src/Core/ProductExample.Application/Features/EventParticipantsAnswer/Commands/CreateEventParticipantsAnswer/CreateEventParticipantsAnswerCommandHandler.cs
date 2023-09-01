using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventParticipantsAnswer.Commands.CreateEventParticipantsAnswer
{
    public class CreateEventParticipantsAnswerCommandHandler : IRequestHandler<CreateEventParticipantsAnswerCommandRequest, IDataResult>
    {
        private readonly IEventParticipantsAnswerRepository _eventParticipantsAnswerRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateEventParticipantsAnswerCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEventParticipantsAnswerCommandHandler(IEventParticipantsAnswerRepository eventParticipantsAnswerRepository, IMapper mapper, IValidator<CreateEventParticipantsAnswerCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _eventParticipantsAnswerRepository = eventParticipantsAnswerRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateEventParticipantsAnswerCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
