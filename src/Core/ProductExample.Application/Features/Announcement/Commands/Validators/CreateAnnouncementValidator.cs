using FluentValidation;
using Lms.Application.Features.Announcement.Commands.CreateAnnouncement;

namespace Lms.Application.Features.Announcement.Commands.Validators
{
    public class CreateAnnouncementValidator: AbstractValidator<CreateAnnouncementCommandRequest>
    {
        public CreateAnnouncementValidator()
        {
            
        }
    }
}
