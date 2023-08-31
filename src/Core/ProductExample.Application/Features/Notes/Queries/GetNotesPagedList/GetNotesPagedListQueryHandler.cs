using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notes.Queries.GetNotesPagedList
{
    public class GetNotesPagedListQueryHandler : IRequestHandler<GetNotesPagedListQueryRequest, IPagedDataResult<GetNotesPagedListQueryResponse>>
    {
        readonly INotesRepository _notesRepository;
        IMapper _mapper;

        public GetNotesPagedListQueryHandler(INotesRepository notesRepository, IMapper mapper)
        {
            _notesRepository = notesRepository;
            _mapper = mapper;
        }

        public Task<IPagedDataResult<GetNotesPagedListQueryResponse>> Handle(GetNotesPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
