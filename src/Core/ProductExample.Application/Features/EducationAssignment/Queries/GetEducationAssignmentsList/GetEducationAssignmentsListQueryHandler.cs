using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.EducationAssignments.Queries.GetEducationAssignmentsList
{
    public class GetEducationAssignmentsListQueryHandler : IRequestHandler<GetEducationAssignmentsListQueryRequest, IDataResult<IEnumerable<GetEducationAssignmentsListQueryResponse>>>
    {
        readonly IEducationAssignmentsRepository _educationAssignmentsRepository;
        IMapper _mapper;
        public GetEducationAssignmentsListQueryHandler(IEducationAssignmentsRepository educationAssignmentsRepository, IMapper mapper)
        {
            _educationAssignmentsRepository = educationAssignmentsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetEducationAssignmentsListQueryResponse>>> Handle(GetEducationAssignmentsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _educationAssignmentsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetEducationAssignmentsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetEducationAssignmentsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
