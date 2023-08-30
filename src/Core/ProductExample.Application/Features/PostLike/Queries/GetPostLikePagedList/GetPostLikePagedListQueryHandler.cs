using AutoMapper;
using Lms.Application.Features.Category.Queries.GetCategoryPagedList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.PostLike.Queries.GetPostLikePagedList
{
    public class GetPostLikePagedListQueryHandler : IRequestHandler<GetPostLikePagedListQueryRequest, IPagedDataResult<GetPostLikePagedListQueryResponse>>
    {
        readonly IPostLikeRepository _postLikeRepository;
        IMapper _mapper;

        public GetPostLikePagedListQueryHandler(IPostLikeRepository postLikeRepository, IMapper mapper)
        {
            _postLikeRepository = postLikeRepository;
            _mapper = mapper;
        }

        public Task<IPagedDataResult<GetPostLikePagedListQueryResponse>> Handle(GetPostLikePagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
