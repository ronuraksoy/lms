using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Forum.Queries.GetForumList
{
    public class GetForumListQueryHandler : IRequestHandler<GetForumListQueryRequest, IDataResult<IEnumerable<GetForumListQueryResponse>>>
    {
        readonly IForumRepository _forumRepository;
        IMapper _mapper;
        public GetForumListQueryHandler(IForumRepository forumRepository, IMapper mapper)
        {
            _forumRepository = forumRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetForumListQueryResponse>>> Handle(GetForumListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _forumRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetForumListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetForumListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
