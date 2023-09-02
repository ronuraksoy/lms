using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Achievements.Commands.CreateAchievements
{
    public class CreateAchievementsCommandHandler : IRequestHandler<CreateAchievementsCommandRequest, IDataResult>
    {
        private readonly IAchievementsRepository _achievementsRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateAchievementsCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateAchievementsCommandHandler(IAchievementsRepository achievementsRepository, IMapper mapper, IValidator<CreateAchievementsCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _achievementsRepository = achievementsRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateAchievementsCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
