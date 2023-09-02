using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ContactMessage.Queries.GetContactMessageList
{
    public class GetContactMessageListQueryHandler : IRequestHandler<GetContactMessageListQueryRequest, IDataResult<IEnumerable<GetContactMessageListQueryResponse>>>
    {
        readonly IContactMessageRepository _contactMessageRepository;
        IMapper _mapper;
        public GetContactMessageListQueryHandler(IContactMessageRepository contactMessageRepository, IMapper mapper)
        {
            _contactMessageRepository = contactMessageRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetContactMessageListQueryResponse>>> Handle(GetContactMessageListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _contactMessageRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetContactMessageListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetContactMessageListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
