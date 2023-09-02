using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Faculty.Queries.GetFacultyById
{
    public class GetFacultyByIdQueryHandler : IRequestHandler<GetFacultyByIdQueryRequest, IDataResult<GetFacultyByIdQueryResponse>>
    {
        readonly IFacultyRepository _facultyRepository;
        IMapper _mapper;
        public GetFacultyByIdQueryHandler(IFacultyRepository facultyRepository, IMapper mapper)
        {
            _facultyRepository = facultyRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetFacultyByIdQueryResponse>> Handle(GetFacultyByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _facultyRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetFacultyByIdQueryResponse>(data);
            return new DataResult<GetFacultyByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
