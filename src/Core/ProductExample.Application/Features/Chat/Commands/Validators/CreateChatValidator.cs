using FluentValidation;
using Lms.Application.Features.Chat.Commands.CreateChat;

namespace Lms.Application.Features.Chat.Commands.Validators
{
    public class CreateChatValidator : AbstractValidator<CreateChatCommandRequest>
    {
        public CreateChatValidator()
        {
        }
    }
}
