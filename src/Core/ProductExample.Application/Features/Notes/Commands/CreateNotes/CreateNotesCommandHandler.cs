using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notes.Commands.CreateNotes
{
    public class CreateNotesCommandHandler : IRequestHandler<CreateNotesCommandRequest, IDataResult>
    {
        private readonly INotesRepository _notesRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateNotesCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateNotesCommandHandler(IUnitOfWork unitOfWork, IValidator<CreateNotesCommandRequest> validator, IMapper mapper, INotesRepository notesRepository)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
            _mapper = mapper;
            _notesRepository = notesRepository;
        }

        public Task<IDataResult> Handle(CreateNotesCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
