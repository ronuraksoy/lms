using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.CurriculumLesson.Commands.CreateCurriculumLesson
{
    public class CreateCurriculumLessonCommandHandler : IRequestHandler<CreateCurriculumLessonCommandRequest, IDataResult>
    {
        private readonly ICurriculumLessonRepository _curriculumLessonRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateCurriculumLessonCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCurriculumLessonCommandHandler(ICurriculumLessonRepository curriculumLessonRepository, IMapper mapper, IValidator<CreateCurriculumLessonCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _curriculumLessonRepository = curriculumLessonRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult> Handle(CreateCurriculumLessonCommandRequest request, CancellationToken cancellationToken)
        {
            return new DataResult
            {
                Success = true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
