using FluentValidation;
using Lms.Application.Features.Lessons.Commands.CreateLessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Lessons.Commands.Validators
{
    public class CreateLessonsValidator: AbstractValidator<CreateLessonsCommandRequest>
    {
        public CreateLessonsValidator()
        {
            
        }
    }
}
