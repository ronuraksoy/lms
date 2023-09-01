using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.StudentAssesments.Queries.GetStudentAssesmentsById
{
    public class GetStudentAssesmentsByIdQueryHandler : IRequestHandler<GetStudentAssesmentsByIdQueryRequest, IDataResult<GetStudentAssesmentsByIdQueryResponse>>
    {
        readonly IStudentAssesmentsRepository _studentAssesmentsRepository;
        IMapper _mapper;
        public GetStudentAssesmentsByIdQueryHandler(IStudentAssesmentsRepository studentAssesmentsRepository, IMapper mapper)
        {
            _studentAssesmentsRepository = studentAssesmentsRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetStudentAssesmentsByIdQueryResponse>> Handle(GetStudentAssesmentsByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _studentAssesmentsRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetStudentAssesmentsByIdQueryResponse>(data);
            return new DataResult<GetStudentAssesmentsByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
