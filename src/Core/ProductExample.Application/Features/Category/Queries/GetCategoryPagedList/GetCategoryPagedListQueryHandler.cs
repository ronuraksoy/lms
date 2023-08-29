using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Category.Queries.GetCategoryPagedList
{
    public class GetCategoryPagedListQueryHandler : IRequestHandler<GetCategoryPagedListQueryRequest, IPagedDataResult<GetCategoryPagedListQueryResponse>>
    {
        readonly ICategoryRepository _categoryRepository;
        IMapper _mapper;
        public Task<IPagedDataResult<GetCategoryPagedListQueryResponse>> Handle(GetCategoryPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public GetCategoryPagedListQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
    }
}
