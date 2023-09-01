using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Events.Commands.CreateEvents
{
    public class CreateEventsCommandHandler : IRequestHandler<CreateEventsCommandRequest, IDataResult>
    {
        private readonly IEventsRepository _eventsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateEventsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEventsCommandHandler(IEventsRepository eventsRepository, IMapper mapper, IValidator<CreateEventsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _eventsRepository = eventsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateEventsCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
