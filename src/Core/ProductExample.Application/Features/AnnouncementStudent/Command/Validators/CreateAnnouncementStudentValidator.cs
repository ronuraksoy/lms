using FluentValidation;
using Lms.Application.Features.AnnouncementStudent.Commands.CreateAnnouncementStudent;

namespace Lms.Application.Features.AnnouncementStudent.Commands.Validators
{
    public class CreateAnnouncementStudentValidator: AbstractValidator<CreateAnnouncementStudentCommandRequest>
    {
        public CreateAnnouncementStudentValidator()
        {
            
        }
    }
}
