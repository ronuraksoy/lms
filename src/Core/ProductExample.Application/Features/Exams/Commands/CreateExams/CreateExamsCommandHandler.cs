using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Exams.Commands.CreateExams
{
    public class CreateExamsCommandHandler : IRequestHandler<CreateExamsCommandRequest, IDataResult>
    {
        private readonly IExamsRepository _examsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateExamsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateExamsCommandHandler(IExamsRepository examsRepository, IMapper mapper, IValidator<CreateExamsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _examsRepository = examsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateExamsCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
