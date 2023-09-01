using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AssignmentResult.Queries.GetAssignmentResultList
{
    public class GetAssignmentResultListQueryHandler : IRequestHandler<GetAssignmentResultListQueryRequest, IDataResult<IEnumerable<GetAssignmentResultListQueryResponse>>>
    {
        readonly IAssignmentResultRepository _assignmentResultRepository;
        IMapper _mapper;
        public GetAssignmentResultListQueryHandler(IAssignmentResultRepository assignmentResultRepository, IMapper mapper)
        {
            _assignmentResultRepository = assignmentResultRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetAssignmentResultListQueryResponse>>> Handle(GetAssignmentResultListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _assignmentResultRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetAssignmentResultListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetAssignmentResultListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
