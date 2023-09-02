using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ForumCategory.Queries.GetForumCategoryList
{
    public class GetForumCategoryListQueryHandler : IRequestHandler<GetForumCategoryListQueryRequest, IDataResult<IEnumerable<GetForumCategoryListQueryResponse>>>
    {
        readonly IForumCategoryRepository _forumCategoryRepository;
        IMapper _mapper;
        public GetForumCategoryListQueryHandler(IForumCategoryRepository forumCategoryRepository, IMapper mapper)
        {
            _forumCategoryRepository = forumCategoryRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetForumCategoryListQueryResponse>>> Handle(GetForumCategoryListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _forumCategoryRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetForumCategoryListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetForumCategoryListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
