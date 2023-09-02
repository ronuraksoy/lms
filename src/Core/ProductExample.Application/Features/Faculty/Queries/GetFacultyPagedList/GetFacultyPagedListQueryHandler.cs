using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Faculty.Queries.GetFacultyPagedList
{
    public class GetFacultyPagedListQueryHandler : IRequestHandler<GetFacultyPagedListQueryRequest, IPagedDataResult<GetFacultyPagedListQueryResponse>>
    {
        readonly IFacultyRepository _facultyRepository;
        IMapper _mapper;
        public async Task<IPagedDataResult<GetFacultyPagedListQueryResponse>> Handle(GetFacultyPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _facultyRepository.GetPagedList(request);
            var result = _mapper.Map<IEnumerable<GetFacultyPagedListQueryResponse>>(data.Data);
            return new PagedDataResult<GetFacultyPagedListQueryResponse>(data.RecordsTotal, data.RecordsFiltered, result, true, "Başarılı işlem...");
        }

        public GetFacultyPagedListQueryHandler(IFacultyRepository facultyRepository, IMapper mapper)
        {
            _facultyRepository = facultyRepository;
            _mapper = mapper;
        }
    }
}
