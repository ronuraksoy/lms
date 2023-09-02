using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Curriculum.Commands.CreateCurriculum
{
    public class CreateCurriculumCommandHandler : IRequestHandler<CreateCurriculumCommandRequest, IDataResult>
    {
        private readonly ICurriculumRepository _curriculumRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateCurriculumCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCurriculumCommandHandler(ICurriculumRepository curriculumRepository, IMapper mapper, IValidator<CreateCurriculumCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _curriculumRepository = curriculumRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateCurriculumCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
