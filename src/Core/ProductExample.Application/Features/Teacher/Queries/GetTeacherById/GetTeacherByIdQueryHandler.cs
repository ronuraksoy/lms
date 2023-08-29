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

namespace Lms.Application.Features.Teacher.Queries.GetTeacherById
{
    public class GetTeacherByIdQueryHandler : IRequestHandler<GetTeacherByIdQueryRequest, IDataResult<GetTeacherByIdQueryResponse>>
    {
        readonly ITeacherRepository _teacherRepository;
        IMapper _mapper;
        public GetTeacherByIdQueryHandler(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }
        public async Task<IDataResult<GetTeacherByIdQueryResponse>> Handle(GetTeacherByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _teacherRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetTeacherByIdQueryResponse>(data);
            return new DataResult<GetTeacherByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
