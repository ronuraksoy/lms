using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ContactMessage.Commands.CreateContactMessage
{
    public class CreateContactMessageCommandHandler : IRequestHandler<CreateContactMessageCommandRequest, IDataResult>
    {
        private readonly IContactMessageRepository _contactMessageRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateContactMessageCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateContactMessageCommandHandler(IContactMessageRepository contactMessageRepository, IMapper mapper, IValidator<CreateContactMessageCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _contactMessageRepository = contactMessageRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateContactMessageCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
