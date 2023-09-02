using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ContactMessage.Queries.GetContactMessageById
{
    public class GetContactMessageByIdQueryHandler : IRequestHandler<GetContactMessageByIdQueryRequest, IDataResult<GetContactMessageByIdQueryResponse>>
    {
        readonly IContactMessageRepository _contactMessageRepository;
        IMapper _mapper;
        public GetContactMessageByIdQueryHandler(IContactMessageRepository contactMessageRepository, IMapper mapper)
        {
            _contactMessageRepository = contactMessageRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetContactMessageByIdQueryResponse>> Handle(GetContactMessageByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _contactMessageRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetContactMessageByIdQueryResponse>(data);
            return new DataResult<GetContactMessageByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
