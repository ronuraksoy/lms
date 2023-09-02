using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Chat.Commands.CreateChat
{
    public class CreateChatCommandHandler : IRequestHandler<CreateChatCommandRequest, IDataResult>
    {
        private readonly IChatRepository _chatRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateChatCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateChatCommandHandler(IChatRepository chatRepository, IMapper mapper, IValidator<CreateChatCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _chatRepository = chatRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateChatCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
