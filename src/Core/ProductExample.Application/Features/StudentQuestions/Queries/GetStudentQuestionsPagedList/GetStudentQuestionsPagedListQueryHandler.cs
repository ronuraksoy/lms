using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentQuestions.Queries.GetStudentQuestionsPagedList
{
    public class GetStudentQuestionsPagedListQueryHandler : IRequestHandler<GetStudentQuestionsPagedListQueryRequest, IPagedDataResult<GetStudentQuestionsPagedListQueryResponse>>
    {
        readonly IStudentQuestionsRepository _studentQuestionsRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetStudentQuestionsPagedListQueryResponse>> Handle(GetStudentQuestionsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentQuestionsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetStudentQuestionsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetStudentQuestionsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetStudentQuestionsPagedListQueryHandler(IStudentQuestionsRepository studentQuestionsRepository, IMapper mapper)
        {
            _studentQuestionsRepository = studentQuestionsRepository;
            _mapper = mapper;
        }
    }
}
