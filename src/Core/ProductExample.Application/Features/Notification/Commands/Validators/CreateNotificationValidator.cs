using FluentValidation;
using Lms.Application.Features.Notification.Commands.CreateNotification;

namespace Lms.Application.Features.Notification.Commands.Validators
{
    public class CreateNotificationValidator:AbstractValidator<CreateNotificationCommandRequest>
    {
        public CreateNotificationValidator() { }
    }
}
