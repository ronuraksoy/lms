using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Document.Queries.GetDocumentPagedList
{
    public class GetDocumentPagedListQueryHandler : IRequestHandler<GetDocumentPagedListQueryRequest, IPagedDataResult<GetDocumentPagedListQueryResponse>>
    {
        readonly IDocumentRepository _documentRepository;
        IMapper _mapper;
        public GetDocumentPagedListQueryHandler(IDocumentRepository documentRepository, IMapper mapper)
        {
            _documentRepository = documentRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetDocumentPagedListQueryResponse>> Handle(GetDocumentPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _documentRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetDocumentPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetDocumentPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
