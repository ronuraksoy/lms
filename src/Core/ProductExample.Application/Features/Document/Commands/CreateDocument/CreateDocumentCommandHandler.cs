using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Document.Commands.CreateDocument
{
    public class CreateDocumentCommandHandler : IRequestHandler<CreateDocumentCommandRequest, IDataResult>
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateDocumentCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateDocumentCommandHandler(IDocumentRepository documentRepository, IMapper mapper, IValidator<CreateDocumentCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _documentRepository = documentRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateDocumentCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
