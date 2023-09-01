using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAssignments.Queries.GetStudentAssignmentsList
{
    public class GetStudentAssignmentsListQueryHandler : IRequestHandler<GetStudentAssignmentsListQueryRequest, IDataResult<IEnumerable<GetStudentAssignmentsListQueryResponse>>>
    {
        readonly IStudentAssignmentsRepository _studentAssignmentsRepository;
        IMapper _mapper;
        public GetStudentAssignmentsListQueryHandler(IStudentAssignmentsRepository studentAssignmentsRepository, IMapper mapper)
        {
            _studentAssignmentsRepository = studentAssignmentsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetStudentAssignmentsListQueryResponse>>> Handle(GetStudentAssignmentsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentAssignmentsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetStudentAssignmentsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetStudentAssignmentsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
