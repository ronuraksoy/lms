using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Common.Application.UnitOfWork;
using Lms.Comman.Domain.Entities;
using Lms.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lms.Application.Features.Category.Commands.CreateCategory;

namespace Lms.Application.Features.AchievementCategory.Commands.CreateAchievementCategory
{
    public class CreateAchievementCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, IDataResult>
    {
        private readonly IAchievementCategoryRepository _achievementCategoryRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateCategoryCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateAchievementCategoryCommandHandler(IAchievementCategoryRepository achievementCategoryRepository, IMapper mapper, IValidator<CreateCategoryCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _achievementCategoryRepository = achievementCategoryRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
