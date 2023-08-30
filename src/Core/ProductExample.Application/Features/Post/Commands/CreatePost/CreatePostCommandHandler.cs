using AutoMapper;
using FluentValidation;
using Lms.Application.Features.Category.Commands.CreateCategory;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using Lms.Common.Application.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Post.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommandRequest, IDataResult>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreatePostCommandRequest> _validator;
        private readonly IUnitOfWork _unitOfWork;
        public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper, IValidator<CreatePostCommandRequest> validator, IUnitOfWork unitOfWork)
        {
            _postRepository = postRepository;
            _mapper = mapper;
            _validator = validator;
            _unitOfWork = unitOfWork;
        }

       

        public Task<IDataResult> Handle(CreatePostCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
