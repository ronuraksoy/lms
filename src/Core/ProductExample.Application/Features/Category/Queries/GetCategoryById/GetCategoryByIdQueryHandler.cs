using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Teacher.Queries.GetCategoryById
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQueryRequest, IDataResult<GetCategoryByIdQueryResponse>>
    {
        readonly ICategoryRepository _categoryRepository;
        IMapper _mapper;
        public GetCategoryByIdQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetCategoryByIdQueryResponse>> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _categoryRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetCategoryByIdQueryResponse>(data);
            return new DataResult<GetCategoryByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
