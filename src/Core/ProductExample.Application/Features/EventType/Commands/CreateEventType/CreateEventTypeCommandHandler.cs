using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EventType.Commands.CreateEventType
{
    public class CreateEventTypeCommandHandler : IRequestHandler<CreateEventTypeCommandRequest, IDataResult>
    {
        private readonly IEventTypeRepository _eventTypeRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateEventTypeCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEventTypeCommandHandler(IEventTypeRepository eventTypeRepository, IMapper mapper, IValidator<CreateEventTypeCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _eventTypeRepository = eventTypeRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateEventTypeCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
