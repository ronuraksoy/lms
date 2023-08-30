using Lms.Application.Features.Base;
using System;

namespace Lms.Application.Features.School.Commands.CreateSchool
{
    public class CreateSchoolCommandRequest : BaseRequest
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Detail { get; set; }
        public string? Note { get; set; }
    }
}
