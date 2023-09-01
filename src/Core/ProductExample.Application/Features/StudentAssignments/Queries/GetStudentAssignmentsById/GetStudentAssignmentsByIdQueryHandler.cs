using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAssignments.Queries.GetStudentAssignmentsById
{
    public class GetStudentAssignmentsByIdQueryHandler : IRequestHandler<GetStudentAssignmentsByIdQueryRequest, IDataResult<GetStudentAssignmentsByIdQueryResponse>>
    {
        readonly IStudentAssignmentsRepository _studentAssignmentsRepository;
        IMapper _mapper;
        public GetStudentAssignmentsByIdQueryHandler(IStudentAssignmentsRepository studentAssignmentsRepository, IMapper mapper)
        {
            _studentAssignmentsRepository = studentAssignmentsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetStudentAssignmentsByIdQueryResponse>> Handle(GetStudentAssignmentsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentAssignmentsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetStudentAssignmentsByIdQueryResponse>(data);
            return new DataResult<GetStudentAssignmentsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
