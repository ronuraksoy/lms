using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionType.Queries.GetQuestionTypePagedList
{
    public class GetQuestionTypePagedListQueryHandler : IRequestHandler<GetQuestionTypePagedListQueryRequest, IPagedDataResult<GetQuestionTypePagedListQueryResponse>>
    {
        readonly IQuestionTypeRepository _questionTypeRepository;
        IMapper _mapper;

        public GetQuestionTypePagedListQueryHandler(IMapper mapper, IQuestionTypeRepository questionTypeRepository)
        {
            _mapper = mapper;
            _questionTypeRepository = questionTypeRepository;
        }

        public Task<IPagedDataResult<GetQuestionTypePagedListQueryResponse>> Handle(GetQuestionTypePagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
