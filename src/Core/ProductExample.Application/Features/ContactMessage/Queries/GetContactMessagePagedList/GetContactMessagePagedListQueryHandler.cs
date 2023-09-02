using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ContactMessage.Queries.GetContactMessagePagedList
{
    public class GetContactMessagePagedListQueryHandler : IRequestHandler<GetContactMessagePagedListQueryRequest, IPagedDataResult<GetContactMessagePagedListQueryResponse>>
    {
        readonly IContactMessageRepository _contactMessageRepository;
        IMapper _mapper;
        public GetContactMessagePagedListQueryHandler(IContactMessageRepository contactMessageRepository, IMapper mapper)
        {
            _contactMessageRepository = contactMessageRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetContactMessagePagedListQueryResponse>> Handle(GetContactMessagePagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _contactMessageRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetContactMessagePagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetContactMessagePagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
