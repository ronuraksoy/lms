using Lms.Domain.Entities;

namespace Lms.Application.Features.Notes.Queries.GetNotesById
{
    public class GetNotesByIdQueryResponse
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LessonId { get; set; }
        public  Lms.Domain.Entities.Lessons Lessons { get; set; }
    }
}
