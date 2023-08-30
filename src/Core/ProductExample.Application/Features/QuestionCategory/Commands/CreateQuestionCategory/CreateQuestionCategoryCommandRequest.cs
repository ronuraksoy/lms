using Lms.Application.Features.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.QuestionCategory.Commands.CreateQuestionCategory
{
    public class CreateQuestionCategoryCommandRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
