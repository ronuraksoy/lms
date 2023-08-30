using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetCategoryList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.PostLike.Queries.GetPostLikeList
{
    public class GetPostLikeListQueryHandler : IRequestHandler<GetPostLikeListQueryRequest, IDataResult<IEnumerable<GetPostLikeListQueryResponse>>>
    {
        readonly IPostLikeRepository _postLikeRepository;
        IMapper _mapper;
        public GetPostLikeListQueryHandler(IPostLikeRepository postLikeRepository, IMapper mapper)
        {
            _postLikeRepository = postLikeRepository;
            _mapper = mapper;
        }

        public async  Task<IDataResult<IEnumerable<GetPostLikeListQueryResponse>>> Handle(GetPostLikeListQueryRequest request, CancellationToken cancellationToken)
        {

            var data = await _postLikeRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetPostLikeListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetPostLikeListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
