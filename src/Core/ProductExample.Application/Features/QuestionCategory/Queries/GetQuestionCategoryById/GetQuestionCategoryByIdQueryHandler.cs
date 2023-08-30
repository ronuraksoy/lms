using AutoMapper;
using Lms.Application.Features.Notification.Queries.GetNotificationById;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionCategory.Queries.GetQuestionCategoryById
{
    public class GetQuestionCategoryByIdQueryHandler: IRequestHandler<GetQuestionCategoryByIdQueryRequest, IDataResult<GetQuestionCategoryByIdQueryResponse>>
    {
        readonly IQuestionCategoryRepository _questionCategoryRepository;
        IMapper _mapper;

        public GetQuestionCategoryByIdQueryHandler(IQuestionCategoryRepository questionCategoryRepository, IMapper mapper)
        {
            _questionCategoryRepository = questionCategoryRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<GetQuestionCategoryByIdQueryResponse>> Handle(GetQuestionCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _questionCategoryRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetQuestionCategoryByIdQueryResponse>(data);
            return new DataResult<GetQuestionCategoryByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
