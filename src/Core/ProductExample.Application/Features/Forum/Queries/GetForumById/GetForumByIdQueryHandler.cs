using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Forum.Queries.GetForumById
{
    public class GetForumByIdQueryHandler : IRequestHandler<GetForumByIdQueryRequest, IDataResult<GetForumByIdQueryResponse>>
    {
        readonly IForumRepository _forumRepository;
        IMapper _mapper;
        public GetForumByIdQueryHandler(IForumRepository forumRepository, IMapper mapper)
        {
            _forumRepository = forumRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetForumByIdQueryResponse>> Handle(GetForumByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _forumRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetForumByIdQueryResponse>(data);
            return new DataResult<GetForumByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
