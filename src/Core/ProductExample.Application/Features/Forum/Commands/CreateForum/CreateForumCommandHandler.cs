using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Forum.Commands.CreateForum
{
    public class CreateForumCommandHandler : IRequestHandler<CreateForumCommandRequest, IDataResult>
    {
        private readonly IForumRepository _forumRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateForumCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreateForumCommandHandler(IForumRepository forumRepository, IMapper mapper, IValidator<CreateForumCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _forumRepository = forumRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

        public Task<IDataResult> Handle(CreateForumCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
