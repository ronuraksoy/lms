using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Faculty.Commands.CreateFaculty
{
    public class CreateFacultyCommandHandler : IRequestHandler<CreateFacultyCommandRequest, IDataResult>
    {
        private readonly IFacultyRepository _facultyRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateFacultyCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateFacultyCommandHandler(IFacultyRepository facultyRepository, IMapper mapper, IValidator<CreateFacultyCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _facultyRepository = facultyRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateFacultyCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
