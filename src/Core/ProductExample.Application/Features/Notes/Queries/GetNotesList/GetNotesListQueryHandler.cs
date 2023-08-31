using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notes.Queries.GetNotesList
{
    public class GetNotesListQueryHandler : IRequestHandler<GetNotesListQueryRequest, IDataResult<IEnumerable<GetNotesListQueryResponse>>>
    {
        readonly INotesRepository _notesRepository;
        IMapper _mapper;

        public GetNotesListQueryHandler(INotesRepository notesRepository, IMapper mapper)
        {
            _notesRepository = notesRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<IEnumerable<GetNotesListQueryResponse>>> Handle(GetNotesListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _notesRepository.GetListAsync();
            var result = _mapper.Map<IEnumerable<GetNotesListQueryResponse>>(data);
            return new DataResult<IEnumerable<GetNotesListQueryResponse>>
            {
                Success = true,
                Message = "Başarılı işlem",
                Data = result
            };
        }
    }
}
