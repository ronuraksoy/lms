using AutoMapper;
using Lms.Application.Features.Lessons.Queries.GetLessonsById;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notes.Queries.GetNotesById
{
    public class GetNotesByIdQueryHandler : IRequestHandler<GetNotesByIdQueryRequest, IDataResult<GetNotesByIdQueryResponse>>
    {
        readonly INotesRepository _notesRepository;
        IMapper _mapper;

        public GetNotesByIdQueryHandler(INotesRepository notesRepository, IMapper mapper)
        {
            _notesRepository = notesRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<GetNotesByIdQueryResponse>> Handle(GetNotesByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _notesRepository.GetByIdAsync(request);
            var result = _mapper.Map<GetNotesByIdQueryResponse>(data);
            return new DataResult<GetNotesByIdQueryResponse>
            {
                Success = true,
                Message = "Başarılı...",
                Data = result
            };
        }
    }
}
