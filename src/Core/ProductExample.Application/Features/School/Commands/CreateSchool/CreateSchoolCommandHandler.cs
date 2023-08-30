using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.School.Commands.CreateSchool
{
    public class CreateSchoolCommandHandler : IRequestHandler<CreateSchoolCommandRequest, IDataResult>
    {
        private readonly ISchoolRepository _schoolRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateSchoolCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateSchoolCommandHandler(ISchoolRepository schoolRepository, IMapper mapper, IValidator<CreateSchoolCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _schoolRepository = schoolRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateSchoolCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
