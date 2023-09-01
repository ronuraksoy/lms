using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Teacher.Queries.GetTeacherList
{
    public class GetTeacherListQueryHandler : IRequestHandler<GetTeacherListQueryRequest, IDataResult<IEnumerable<GetTeacherListQueryResponse>>>
    {
        readonly ITeacherRepository _teacherRepository;
        IMapper _mapper;
        public GetTeacherListQueryHandler(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<IEnumerable<GetTeacherListQueryResponse>>> Handle(GetTeacherListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _teacherRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetTeacherListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetTeacherListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
