using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Unit.Commands.CreateUnit
{
    public class CreateUnitCommandHandler : IRequestHandler<CreateUnitCommandRequest, IDataResult>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateUnitCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateUnitCommandHandler(IUnitRepository unitRepository, IMapper mapper, IValidator<CreateUnitCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateUnitCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
