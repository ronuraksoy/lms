using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ForumContent.Queries.GetForumContentById
{
    public class GetForumContentByIdQueryHandler : IRequestHandler<GetForumContentByIdQueryRequest, IDataResult<GetForumContentByIdQueryResponse>>
    {
        readonly IForumContentRepository _forumContentRepository;
        IMapper _mapper;
        public GetForumContentByIdQueryHandler(IForumContentRepository forumContentRepository, IMapper mapper)
        {
            _forumContentRepository = forumContentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetForumContentByIdQueryResponse>> Handle(GetForumContentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _forumContentRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetForumContentByIdQueryResponse>(data);
            return new DataResult<GetForumContentByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
