using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Document.Queries.GetDocumentList
{
    public class GetDocumentListQueryHandler : IRequestHandler<GetDocumentListQueryRequest, IDataResult<IEnumerable<GetDocumentListQueryResponse>>>
    {
        readonly IDocumentRepository _documentRepository;
        IMapper _mapper;
        public GetDocumentListQueryHandler(IDocumentRepository documentRepository, IMapper mapper)
        {
            _documentRepository = documentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetDocumentListQueryResponse>>> Handle(GetDocumentListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _documentRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetDocumentListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetDocumentListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
