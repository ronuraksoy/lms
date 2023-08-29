using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Teacher.Queries.GetCategoryList
{
    public class GetCategoryListQueryHandler : IRequestHandler<GetCategoryListQueryRequest, IDataResult<IEnumerable<GetCategoryListQueryResponse>>>
    {
        readonly ICategoryRepository _categoryRepository;
        IMapper _mapper;
        public GetCategoryListQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetCategoryListQueryResponse>>> Handle(GetCategoryListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _categoryRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetCategoryListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetCategoryListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
