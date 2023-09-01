using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.BookRecommendations.Queries.GetBookRecommendationsById
{
    public class GetBookRecommendationsByIdQueryHandler : IRequestHandler<GetBookRecommendationsByIdQueryRequest, IDataResult<GetBookRecommendationsByIdQueryResponse>>
    {
        readonly IBookRecommendationsRepository _bookRecommendationsRepository;
        IMapper _mapper;
        public GetBookRecommendationsByIdQueryHandler(IBookRecommendationsRepository bookRecommendationsRepository, IMapper mapper)
        {
            _bookRecommendationsRepository = bookRecommendationsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetBookRecommendationsByIdQueryResponse>> Handle(GetBookRecommendationsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _bookRecommendationsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetBookRecommendationsByIdQueryResponse>(data);
            return new DataResult<GetBookRecommendationsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
