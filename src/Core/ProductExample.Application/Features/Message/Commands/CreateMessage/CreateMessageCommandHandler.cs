using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Message.Commands.CreateMessage
{
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommandRequest, IDataResult>
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateMessageCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;
        public CreateMessageCommandHandler(IMessageRepository messageRepository, IUnitOfWork unitOfWork, IValidator<CreateMessageCommandRequest> validator, IMapper mapper)
        {
            _messageRepository = messageRepository;
            _unitOfWork = unitOfWork;
            _validator = validator;
            _mapper = mapper;
        }


        public Task<IDataResult> Handle(CreateMessageCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
