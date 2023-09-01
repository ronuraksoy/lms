using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAssesments.Queries.GetStudentAssesmentsList
{
    public class GetStudentAssesmentsListQueryHandler : IRequestHandler<GetStudentAssesmentsListQueryRequest, IDataResult<IEnumerable<GetStudentAssesmentsListQueryResponse>>>
    {
        readonly IStudentAssesmentsRepository _studentAssesmentsRepository;
        IMapper _mapper;
        public GetStudentAssesmentsListQueryHandler(IStudentAssesmentsRepository studentAssesmentsRepository, IMapper mapper)
        {
            _studentAssesmentsRepository = studentAssesmentsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetStudentAssesmentsListQueryResponse>>> Handle(GetStudentAssesmentsListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentAssesmentsRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetStudentAssesmentsListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetStudentAssesmentsListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
