using FluentValidation;
using Lms.Application.Features.Notes.Commands.CreateNotes;

namespace Lms.Application.Features.Notes.Commands.Validators
{
    public class CreateNotesValidator:AbstractValidator<CreateNotesCommandRequest>
    {
        public CreateNotesValidator() { }
    }
}
