using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AchievementCategory.Commands.CreateAchievementCategory
{
    public class CreateAchievementCategoryCommandHandler : IRequestHandler<CreateAchievementCategoryCommandRequest, IDataResult>
    {
        private readonly IAchievementCategoryRepository _achievementCategoryRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateAchievementCategoryCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateAchievementCategoryCommandHandler(IAchievementCategoryRepository achievementCategoryRepository, IMapper mapper, IValidator<CreateAchievementCategoryCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _achievementCategoryRepository = achievementCategoryRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateAchievementCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
