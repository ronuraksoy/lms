using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionCategory.Queries.GetQuestionCategoryList
{
    public class GetQuestionCategoryListQueryHandler : IRequestHandler<GetQuestionCategoryListQueryRequest, IDataResult<IEnumerable<GetQuestionCategoryListQueryResponse>>>
    {
        readonly IQuestionCategoryRepository _questionCategoryRepository;
        IMapper _mapper;

        public GetQuestionCategoryListQueryHandler(IMapper mapper, IQuestionCategoryRepository questionCategoryRepository)
        {
            _mapper = mapper;
            _questionCategoryRepository = questionCategoryRepository;
        }

        public async Task<IDataResult<IEnumerable<GetQuestionCategoryListQueryResponse>>> Handle(GetQuestionCategoryListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _questionCategoryRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetQuestionCategoryListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetQuestionCategoryListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
