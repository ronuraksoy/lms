using FluentValidation;
using Lms.Application.Features.Notification.Commands.CreateNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Notification.Commands.Validators
{
    public class CreateNotificationValidator:AbstractValidator<CreateNotificationCommandRequest>
    {
        public CreateNotificationValidator() { }
    }
}
