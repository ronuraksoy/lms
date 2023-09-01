using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Message.Queries.GetMessagePagedList
{
    public class GetMessagePagedListQueryHandler : IRequestHandler<GetMessagePagedListQueryRequest, IPagedDataResult<GetMessagePagedListQueryResponse>>
    {
        readonly IMessageRepository _messageRepository;
        IMapper _mapper;

        public GetMessagePagedListQueryHandler(IMessageRepository messageRepository, IMapper mapper)
        {
            _messageRepository = messageRepository;
            _mapper = mapper;
        }

        
        public Task<IPagedDataResult<GetMessagePagedListQueryResponse>> Handle(GetMessagePagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
