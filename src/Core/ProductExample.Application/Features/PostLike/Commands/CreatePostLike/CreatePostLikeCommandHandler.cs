using AutoMapper;
using FluentValidation;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.PostLike.Commands.CreatePostLike
{
    public class CreatePostLikeCommandHandler : IRequestHandler<CreatePostLikeCommandRequest, IDataResult>
    {
        private readonly IPostLikeRepository _postLikeRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreatePostLikeCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePostLikeCommandHandler(IUnitOfWork unitOfWork, IPostLikeRepository postLikeRepository, IMapper mapper, IValidator<CreatePostLikeCommandRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _postLikeRepository = postLikeRepository;
            _mapper = mapper;
            _validator = validator;
        }

        public Task<IDataResult> Handle(CreatePostLikeCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
