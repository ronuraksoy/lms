using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ValidAnswers.Queries.GetValidAnswersPagedList
{
    public class GetValidAnswersPagedListQueryHandler : IRequestHandler<GetValidAnswersPagedListQueryRequest, IPagedDataResult<GetValidAnswersPagedListQueryResponse>>
    {
        readonly IValidAnswersRepository _validAnswersRepository;
        IMapper _mapper;
        public Task<IPagedDataResult<GetValidAnswersPagedListQueryResponse>> Handle(GetValidAnswersPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public GetValidAnswersPagedListQueryHandler(IValidAnswersRepository validAnswersRepository, IMapper mapper)
        {
            _validAnswersRepository = validAnswersRepository;
            _mapper = mapper;
        }
    }
}
