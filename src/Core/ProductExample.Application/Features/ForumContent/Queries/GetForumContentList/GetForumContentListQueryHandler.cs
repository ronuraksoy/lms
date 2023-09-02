using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ForumContent.Queries.GetForumContentList
{
    public class GetForumContentListQueryHandler : IRequestHandler<GetForumContentListQueryRequest, IDataResult<IEnumerable<GetForumContentListQueryResponse>>>
    {
        readonly IForumContentRepository _forumContentRepository;
        IMapper _mapper;
        public GetForumContentListQueryHandler(IForumContentRepository forumContentRepository, IMapper mapper)
        {
            _forumContentRepository = forumContentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetForumContentListQueryResponse>>> Handle(GetForumContentListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _forumContentRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetForumContentListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetForumContentListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
