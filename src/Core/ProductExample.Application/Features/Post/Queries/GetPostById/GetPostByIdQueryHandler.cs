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

namespace Lms.Application.Features.Post.Queries.GetCategoryById
{
    public class GetPostByIdQueryHandler : IRequestHandler<GetPostByIdQueryRequest, IDataResult<GetPostByIdQueryResponse>>
    {
        readonly IPostRepository _postRepository;
        IMapper _mapper;
        public GetPostByIdQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<GetPostByIdQueryResponse>> Handle(GetPostByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _postRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetPostByIdQueryResponse>(data);
            return new DataResult<GetPostByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
