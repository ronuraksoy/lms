using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EducationAssignments.Commands.CreateEducationAssignments
{
    public class CreateEducationAssignmentsCommandHandler : IRequestHandler<CreateEducationAssignmentsCommandRequest, IDataResult>
    {
        private readonly IEducationAssignmentsRepository _educationAssignmentsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateEducationAssignmentsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEducationAssignmentsCommandHandler(IEducationAssignmentsRepository educationAssignmentsRepository, IMapper mapper, IValidator<CreateEducationAssignmentsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _educationAssignmentsRepository = educationAssignmentsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateEducationAssignmentsCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
