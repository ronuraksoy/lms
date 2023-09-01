using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.BookRecommendations.Queries.GetBookRecommendationsList
{
    public class GetBookRecommendationsListQueryHandler : IRequestHandler<GetBookRecommendationsListQueryRequest, IDataResult<IEnumerable<GetBookRecommendationsListQueryResponse>>>
    {
        readonly IBookRecommendationsRepository _bookRecommendationsRepository;
        IMapper _mapper;
        public GetBookRecommendationsListQueryHandler(IBookRecommendationsRepository bookRecommendationsRepository, IMapper mapper)
        {
            _bookRecommendationsRepository = bookRecommendationsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetBookRecommendationsListQueryResponse>>> Handle(GetBookRecommendationsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _bookRecommendationsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetBookRecommendationsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetBookRecommendationsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
