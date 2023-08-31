using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Product.Queries.GetProductList
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQueryRequest, IDataResult<IEnumerable<GetProductListQueryResponse>>>
    {
        readonly IProductRepository _productRepository;
        IMapper _mapper;

        public GetProductListQueryHandler(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<IDataResult<IEnumerable<GetProductListQueryResponse>>> Handle(GetProductListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _productRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetProductListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetProductListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
