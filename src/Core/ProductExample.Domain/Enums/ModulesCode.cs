using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Domain.Enums
{
    [Flags]
    public enum ModulesCode
    {
        AssignmentComment = 1001001,
        ExamQuestions = 1002001,
        EventQuestions = 1002002,
        SurveyQuestions = 1002003,
        StudentQuestions = 1003001
    }
}
