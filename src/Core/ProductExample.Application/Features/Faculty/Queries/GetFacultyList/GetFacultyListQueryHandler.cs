using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Faculty.Queries.GetFacultyList
{
    public class GetFacultyListQueryHandler : IRequestHandler<GetFacultyListQueryRequest, IDataResult<IEnumerable<GetFacultyListQueryResponse>>>
    {
        readonly IFacultyRepository _facultyRepository;
        IMapper _mapper;
        public GetFacultyListQueryHandler(IFacultyRepository facultyRepository, IMapper mapper)
        {
            _facultyRepository = facultyRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetFacultyListQueryResponse>>> Handle(GetFacultyListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _facultyRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetFacultyListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetFacultyListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
