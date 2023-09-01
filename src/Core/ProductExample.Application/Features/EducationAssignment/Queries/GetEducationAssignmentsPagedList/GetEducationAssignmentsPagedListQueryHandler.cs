using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EducationAssignments.Queries.GetEducationAssignmentsPagedList
{
    public class GetEducationAssignmentsPagedListQueryHandler : IRequestHandler<GetEducationAssignmentsPagedListQueryRequest, IPagedDataResult<GetEducationAssignmentsPagedListQueryResponse>>
    {
        readonly IEducationAssignmentsRepository _educationAssignmentsRepository;
        IMapper _mapper;
        public GetEducationAssignmentsPagedListQueryHandler(IEducationAssignmentsRepository educationAssignmentsRepository, IMapper mapper)
        {
            _educationAssignmentsRepository = educationAssignmentsRepository;
            _mapper = mapper;
        }
        public async Task<IPagedDataResult<GetEducationAssignmentsPagedListQueryResponse>> Handle(GetEducationAssignmentsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _educationAssignmentsRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetEducationAssignmentsPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetEducationAssignmentsPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }
    }
}
