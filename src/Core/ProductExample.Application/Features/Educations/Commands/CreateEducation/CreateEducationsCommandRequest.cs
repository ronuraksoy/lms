using Lms.Application.Features.Base;
using MediatR;
using System;

namespace Lms.Application.Features.Educations.Commands.CreateEducations
{
    public class CreateEducationsCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public string ExamLink { get; set; }
        public int TeacherID { get; set; }
        public Lms.Domain.Entities.Teacher Teacher { get; set; }
        public int? UnitID { get; set; }
        public Unit Unit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Content { get; set; }
        public string Logo { get; set; }
        public string Path { get; set; }
        public bool IsLive { get; set; }
        public int StudentID { get; set; }
    }
}
