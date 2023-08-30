using AutoMapper;
using Lms.Application.Features.Lessons.Queries.GetLessonsList;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Message.Queries.GetMessageList
{
    public class GetMessageListQueryHandler : IRequestHandler<GetMessageListQueryRequest, IDataResult<IEnumerable<GetMessageListQueryResponse>>>
    {
        readonly IMessageRepository _messageRepository;
        IMapper _mapper;

        public GetMessageListQueryHandler(IMapper mapper, IMessageRepository messageRepository)
        {
            _mapper = mapper;
            _messageRepository = messageRepository;
        }

        public async Task<IDataResult<IEnumerable<GetMessageListQueryResponse>>> Handle(GetMessageListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _messageRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetMessageListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetMessageListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
