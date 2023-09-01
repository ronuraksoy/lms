using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.BookRecommendations.Queries.GetBookRecommendationsPagedList
{
    public class GetBookRecommendationsPagedListQueryHandler : IRequestHandler<GetBookRecommendationsPagedListQueryRequest, IPagedDataResult<GetBookRecommendationsPagedListQueryResponse>>
    {
        readonly IBookRecommendationsRepository _bookRecommendationsRepository;
        IMapper _mapper;
        public GetBookRecommendationsPagedListQueryHandler(IBookRecommendationsRepository bookRecommendationsRepository, IMapper mapper)
        {
            _bookRecommendationsRepository = bookRecommendationsRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetBookRecommendationsPagedListQueryResponse>> Handle(GetBookRecommendationsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _bookRecommendationsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetBookRecommendationsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetBookRecommendationsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
