using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Message.Queries.GetMessageById
{
    public class GetMessageByIdQueryHandler : IRequestHandler<GetMessageByIdQueryRequest, IDataResult<GetMessageByIdQueryResponse>>
    {
        readonly IMessageRepository _messageRepository;
        IMapper _mapper;

        public GetMessageByIdQueryHandler(IMessageRepository messageRepository, IMapper mapper)
        {
            _messageRepository = messageRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetMessageByIdQueryResponse>> Handle(GetMessageByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _messageRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetMessageByIdQueryResponse>(data);
            return new DataResult<GetMessageByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
