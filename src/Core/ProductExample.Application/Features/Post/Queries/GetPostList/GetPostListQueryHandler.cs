using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Post.Queries.GetPostList
{
    public class GetPostListQueryHandler : IRequestHandler<GetPostListQueryRequest, IDataResult<IEnumerable<GetPostListQueryResponse>>>
    {
        readonly IPostRepository _postRepository;
        IMapper _mapper;

        public GetPostListQueryHandler(IMapper mapper, IPostRepository postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }

        public async Task<IDataResult<IEnumerable<GetPostListQueryResponse>>> Handle(GetPostListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _postRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetPostListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetPostListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
