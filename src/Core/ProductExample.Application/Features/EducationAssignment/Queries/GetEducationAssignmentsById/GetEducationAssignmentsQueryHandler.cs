using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EducationAssignments.Queries.GetEducationAssignmentsById
{
    public class GetEducationAssignmentsQueryHandler : IRequestHandler<GetEducationAssignmentsByIdQueryRequest, IDataResult<GetEducationAssignmentsByIdQueryResponse>>
    {
        readonly IEducationAssignmentsRepository _educationAssignmentsRepository;
        IMapper _mapper;
        public GetEducationAssignmentsQueryHandler(IEducationAssignmentsRepository educationAssignmentsRepository, IMapper mapper)
        {
            _educationAssignmentsRepository = educationAssignmentsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetEducationAssignmentsByIdQueryResponse>> Handle(GetEducationAssignmentsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _educationAssignmentsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetEducationAssignmentsByIdQueryResponse>(data);
            return new DataResult<GetEducationAssignmentsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
