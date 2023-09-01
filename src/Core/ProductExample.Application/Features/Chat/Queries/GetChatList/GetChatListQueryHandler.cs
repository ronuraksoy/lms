using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Chat.Queries.GetChatList
{
    public class GetChatListQueryHandler : IRequestHandler<GetChatListQueryRequest, IDataResult<IEnumerable<GetChatListQueryResponse>>>
    {
        readonly IChatRepository _chatRepository;
        IMapper _mapper;
        public GetChatListQueryHandler(IChatRepository chatRepository, IMapper mapper)
        {
            _chatRepository = chatRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetChatListQueryResponse>>> Handle(GetChatListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _chatRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetChatListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetChatListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
