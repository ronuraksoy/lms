using Lms.Comman.Domain.Entities;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notes.Queries.GetNotesPagedList
{
    public class GetNotesPagedListQueryResponse:AAuditableEntity<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LessonId { get; set; }
        public Lms.Domain.Entities.Lessons Lessons { get; set; }
    }
}
