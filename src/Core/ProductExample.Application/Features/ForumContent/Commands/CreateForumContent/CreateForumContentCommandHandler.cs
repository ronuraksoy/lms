using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ForumContent.Commands.CreateForumContent
{
    public class CreateForumContentCommandHandler : IRequestHandler<CreateForumContentCommandRequest, IDataResult>
    {
        private readonly IForumContentRepository _forumContentRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateForumContentCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateForumContentCommandHandler(IForumContentRepository forumContentRepository, IMapper mapper, IValidator<CreateForumContentCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _forumContentRepository = forumContentRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateForumContentCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
