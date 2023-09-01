using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventParticipants.Commands.CreateEventParticipants
{
    public class CreateEventParticipantsCommandHandler : IRequestHandler<CreateEventParticipantsCommandRequest, IDataResult>
    {
        private readonly IEventParticipantsRepository _eventParticipantsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateEventParticipantsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEventParticipantsCommandHandler(IEventParticipantsRepository eventParticipantsRepository, IMapper mapper, IValidator<CreateEventParticipantsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _eventParticipantsRepository = eventParticipantsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateEventParticipantsCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
