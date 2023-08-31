using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Lessons.Queries.GetLessonsPagedList
{
    public class GetLessonsPagedListQueryHandler : IRequestHandler<GetLessonsPagedListQueryRequest, IPagedDataResult<GetLessonsPagedListQueryResponse>>
    {
        readonly ILessonsRepository _lessonsRepository;
        IMapper _mapper;
        public Task<IPagedDataResult<GetLessonsPagedListQueryResponse>> Handle(GetLessonsPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public GetLessonsPagedListQueryHandler(ILessonsRepository lessonsRepository, IMapper mapper)
        {
            _lessonsRepository = lessonsRepository;
            _mapper = mapper;
        }
    }
}
