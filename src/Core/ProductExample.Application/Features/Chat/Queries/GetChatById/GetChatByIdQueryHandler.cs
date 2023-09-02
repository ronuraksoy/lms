using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Chat.Queries.GetChatById
{
    public class GetChatByIdQueryHandler : IRequestHandler<GetChatByIdQueryRequest, IDataResult<GetChatByIdQueryResponse>>
    {
        readonly IChatRepository _chatRepository;
        IMapper _mapper;
        public GetChatByIdQueryHandler(IChatRepository chatRepository, IMapper mapper)
        {
            _chatRepository = chatRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetChatByIdQueryResponse>> Handle(GetChatByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _chatRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetChatByIdQueryResponse>(data);
            return new DataResult<GetChatByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
