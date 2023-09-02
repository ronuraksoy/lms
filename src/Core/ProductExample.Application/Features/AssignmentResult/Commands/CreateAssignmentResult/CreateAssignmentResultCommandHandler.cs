using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AssignmentResult.Commands.CreateAssignmentResult
{
    public class CreateAssignmentResultCommandHandler : IRequestHandler<CreateAssignmentResultCommandRequest, IDataResult>
    {
        private readonly IAssignmentResultRepository _assignmentResultRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateAssignmentResultCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateAssignmentResultCommandHandler(IAssignmentResultRepository assignmentResultRepository, IMapper mapper, IValidator<CreateAssignmentResultCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _assignmentResultRepository = assignmentResultRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateAssignmentResultCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
