using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Post.Queries.GetPostPagedList
{
    public class GetPostPagedListQueryHandler : IRequestHandler<GetPostPagedListQueryRequest, IPagedDataResult<GetPostPagedListQueryResponse>>
    {
        readonly IPostRepository _postRepository;
        IMapper _mapper;
        public GetPostPagedListQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public Task<IPagedDataResult<GetPostPagedListQueryResponse>> Handle(GetPostPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
