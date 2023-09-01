using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.ExamsQuestions.Queries.GetExamsQuestionsPagedList
{
    public class GetExamsQuestionsPagedListQueryHandler : IRequestHandler<GetExamsQuestionsPagedListQueryRequest, IPagedDataResult<GetExamsQuestionsPagedListQueryResponse>>
    {
        readonly IExamsQuestionsRepository _examsQuestionsRepository;
        IMapper _mapper;
        public GetExamsQuestionsPagedListQueryHandler(IExamsQuestionsRepository examsQuestionsRepository, IMapper mapper)
        {
            _examsQuestionsRepository = examsQuestionsRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetExamsQuestionsPagedListQueryResponse>> Handle(GetExamsQuestionsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _examsQuestionsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetExamsQuestionsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetExamsQuestionsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
