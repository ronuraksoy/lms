using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Document.Queries.GetDocumentById
{
    public class GetDocumentByIdQueryHandler : IRequestHandler<GetDocumentByIdQueryRequest, IDataResult<GetDocumentByIdQueryResponse>>
    {
        readonly IDocumentRepository _documentRepository;
        IMapper _mapper;
        public GetDocumentByIdQueryHandler(IDocumentRepository documentRepository, IMapper mapper)
        {
            _documentRepository = documentRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetDocumentByIdQueryResponse>> Handle(GetDocumentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _documentRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetDocumentByIdQueryResponse>(data);
            return new DataResult<GetDocumentByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
