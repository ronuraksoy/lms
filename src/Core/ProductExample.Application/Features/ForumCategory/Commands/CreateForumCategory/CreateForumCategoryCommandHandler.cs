using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ForumCategory.Commands.CreateForumCategory
{
    public class CreateForumCategoryCommandHandler : IRequestHandler<CreateForumCategoryCommandRequest, IDataResult>
    {
        private readonly IForumCategoryRepository _forumCategoryRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateForumCategoryCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateForumCategoryCommandHandler(IForumCategoryRepository forumCategoryRepository, IMapper mapper, IValidator<CreateForumCategoryCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _forumCategoryRepository = forumCategoryRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateForumCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
