using FluentValidation;
using Lms.Application.Features.Document.Commands.CreateDocument;

namespace Lms.Application.Features.Document.Commands.Validators
{
    public class CreateDocumentValidator : AbstractValidator<CreateDocumentCommandRequest>
    {
        public CreateDocumentValidator()
        {
        }
    }
}
