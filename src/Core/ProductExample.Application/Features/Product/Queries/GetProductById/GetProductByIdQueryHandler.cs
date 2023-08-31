using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Product.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQueryRequest, IDataResult<GetProductByIdQueryResponse>>
    {
        readonly IProductRepository _productRepository;
        IMapper _mapper;
        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<GetProductByIdQueryResponse>> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _productRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetProductByIdQueryResponse>(data);
            return new DataResult<GetProductByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
