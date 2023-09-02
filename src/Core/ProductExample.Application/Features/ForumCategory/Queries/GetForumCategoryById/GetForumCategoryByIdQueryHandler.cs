using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ForumCategory.Queries.GetForumCategoryById
{
    public class GetForumCategoryByIdQueryHandler : IRequestHandler<GetForumCategoryByIdQueryRequest, IDataResult<GetForumCategoryByIdQueryResponse>>
    {
        readonly IForumCategoryRepository _forumCategoryRepository;
        IMapper _mapper;
        public GetForumCategoryByIdQueryHandler(IForumCategoryRepository forumCategoryRepository, IMapper mapper)
        {
            _forumCategoryRepository = forumCategoryRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetForumCategoryByIdQueryResponse>> Handle(GetForumCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _forumCategoryRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetForumCategoryByIdQueryResponse>(data);
            return new DataResult<GetForumCategoryByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
