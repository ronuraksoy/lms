using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Questions.Queries.GetQuestionPagedList
{
    public class GetQuestionsPagedListQueryHandler : IRequestHandler<GetQuestionsPagedListQueryRequest, IPagedDataResult<GetQuestionsPagedListQueryResponse>>
    {
        readonly IQuestionsRepository _questionsRepository;
        IMapper _mapper;

        public GetQuestionsPagedListQueryHandler(IMapper mapper, IQuestionsRepository questionsRepository)
        {
            _mapper = mapper;
            _questionsRepository = questionsRepository;
        }

        public Task<IPagedDataResult<GetQuestionsPagedListQueryResponse>> Handle(GetQuestionsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
