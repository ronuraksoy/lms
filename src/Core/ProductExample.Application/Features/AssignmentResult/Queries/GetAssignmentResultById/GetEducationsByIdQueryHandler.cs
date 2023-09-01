using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.AssignmentResult.Queries.GetAssignmentResultById
{
    public class GetAssignmentResultByIdQueryHandler : IRequestHandler<GetAssignmentResultByIdQueryRequest, IDataResult<GetAssignmentResultByIdQueryResponse>>
    {
        readonly IAssignmentResultRepository _assignmentResultRepository;
        IMapper _mapper;
        public GetAssignmentResultByIdQueryHandler(IAssignmentResultRepository assignmentResultRepository, IMapper mapper)
        {
            _assignmentResultRepository = assignmentResultRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetAssignmentResultByIdQueryResponse>> Handle(GetAssignmentResultByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _assignmentResultRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetAssignmentResultByIdQueryResponse>(data);
            return new DataResult<GetAssignmentResultByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
