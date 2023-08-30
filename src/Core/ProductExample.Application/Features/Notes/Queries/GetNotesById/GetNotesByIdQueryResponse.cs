using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notes.Queries.GetNotesById
{
    public class GetNotesByIdQueryResponse
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LessonId { get; set; }
        // public  Lessons Lessons { get; set; }
    }
}
