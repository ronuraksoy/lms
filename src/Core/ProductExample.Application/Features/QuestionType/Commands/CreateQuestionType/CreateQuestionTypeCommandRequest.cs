using Lms.Application.Features.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionType.Commands.CreateQuestionType
{
    public class CreateQuestionTypeCommandRequest:BaseRequest
    {
        public string Name { get; set; }
    }
}
