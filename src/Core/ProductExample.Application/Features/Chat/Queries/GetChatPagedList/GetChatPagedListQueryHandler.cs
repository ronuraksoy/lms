using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Chat.Queries.GetChatPagedList
{
    public class GetChatPagedListQueryHandler : IRequestHandler<GetChatPagedListQueryRequest, IPagedDataResult<GetChatPagedListQueryResponse>>
    {
        readonly IChatRepository _chatRepository;
        IMapper _mapper;
        public GetChatPagedListQueryHandler(IChatRepository chatRepository, IMapper mapper)
        {
            _chatRepository = chatRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetChatPagedListQueryResponse>> Handle(GetChatPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _chatRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetChatPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetChatPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
