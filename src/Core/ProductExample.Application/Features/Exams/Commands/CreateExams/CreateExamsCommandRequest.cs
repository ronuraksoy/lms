using Lms.Application.Features.Base;
using System;

namespace Lms.Application.Features.Exams.Commands.CreateExams
{
    public class CreateExamsCommandRequest : BaseRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TeacherID { get; set; }
        public Lms.Domain.Entities.Teacher Teacher { get; set; }
        public int? EducationID { get; set; }
        public Lms.Domain.Entities.Educations Educations { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Time { get; set; }
        public DateTime Hour { get; set; }
        public bool FeedBack { get; set; }
        public int ExamEntitlement { get; set; }
        public bool QuestionNav { get; set; }
    }
}
