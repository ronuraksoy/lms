using System;

namespace Lms.Application.Features.Teacher.Queries.GetTeacherById
{
    public class GetTeacherByIdQueryResponse
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
