using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Classrooms.Commands.CreateClassrooms
{
    public class CreateClassroomsCommandHandler : IRequestHandler<CreateClassroomsCommandRequest, IDataResult>
    {
        private readonly IClassroomsRepository _classroomsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateClassroomsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateClassroomsCommandHandler(IClassroomsRepository classroomsRepository, IMapper mapper, IValidator<CreateClassroomsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _classroomsRepository = classroomsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateClassroomsCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}

