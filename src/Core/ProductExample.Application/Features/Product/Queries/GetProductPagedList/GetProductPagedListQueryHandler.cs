using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Product.Queries.GetProductPagedList
{
    public class GetProductPagedListQueryHandler :IRequestHandler<GetProductPagedListQueryRequest, IPagedDataResult<GetProductPagedListQueryResponse>>
    {
        readonly IProductRepository _productRepository;
        IMapper _mapper;

        public GetProductPagedListQueryHandler(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public Task<IPagedDataResult<GetProductPagedListQueryResponse>> Handle(GetProductPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
