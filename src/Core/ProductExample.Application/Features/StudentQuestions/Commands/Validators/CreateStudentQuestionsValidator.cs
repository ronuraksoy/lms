using FluentValidation;
using Lms.Application.Features.StudentQuestions.Commands.CreateStudentQuestions;

namespace Lms.Application.Features.StudentQuestions.Commands.Validators
{
    public class CreateStudentQuestionsValidator: AbstractValidator<CreateStudentQuestionsCommandRequest>
    {
        public CreateStudentQuestionsValidator()
        {
            
        }
    }
}
