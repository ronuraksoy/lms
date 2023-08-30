using AutoMapper;
using Lms.Application.Features.Teacher.Queries.GetCategoryById;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.PostLike.Queries.GetCategoryById
{
    public class GetPostLikeByIdQueryHandler : IRequestHandler<GetPostLikeByIdQueryRequest, IDataResult<GetPostLikeByIdQueryResponse>>
    {
        readonly IPostLikeRepository _postLikeRepository;
        IMapper _mapper;
        public GetPostLikeByIdQueryHandler(IPostLikeRepository postLikeRepository, IMapper mapper)
        {
            _postLikeRepository = postLikeRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetPostLikeByIdQueryResponse>> Handle(GetPostLikeByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _postLikeRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetPostLikeByIdQueryResponse>(data);
            return new DataResult<GetPostLikeByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
