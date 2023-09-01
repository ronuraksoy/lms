using AutoMapper;
using FluentValidation;
using Lms.Application.Features.Base;
using Lms.Application.Interfaces.Repositories;
using Lms.Common.Application.UnitOfWork;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventSpeakers.Commands.CreateEventSpeakers
{
    public class CreateEventSpeakersCommandHandler : IRequestHandler<CreateEventSpeakersCommandRequest, IDataResult>
    {
        private readonly IEventSpeakersRepository _eventSpeakersRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateEventSpeakersCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEventSpeakersCommandHandler(IEventSpeakersRepository eventSpeakersRepository, IMapper mapper, IValidator<CreateEventSpeakersCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _eventSpeakersRepository = eventSpeakersRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateEventSpeakersCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
