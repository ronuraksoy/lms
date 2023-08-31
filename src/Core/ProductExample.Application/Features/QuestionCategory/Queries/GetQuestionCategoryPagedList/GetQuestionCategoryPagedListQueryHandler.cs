using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionCategory.Queries.GetQuestionCategoryPagedList
{
    public class GetQuestionCategoryPagedListQueryHandler : IRequestHandler<GetQuestionCategoryPagedListQueryRequest, IPagedDataResult<GetQuestionCategoryPagedListQueryResponse>>
    {
        readonly IQuestionCategoryRepository _questionCategoryRepository;
        IMapper _mapper;

        public GetQuestionCategoryPagedListQueryHandler(IMapper mapper, IQuestionCategoryRepository questionCategoryRepository)
        {
            _mapper = mapper;
            _questionCategoryRepository = questionCategoryRepository;
        }

        public Task<IPagedDataResult<GetQuestionCategoryPagedListQueryResponse>> Handle(GetQuestionCategoryPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
