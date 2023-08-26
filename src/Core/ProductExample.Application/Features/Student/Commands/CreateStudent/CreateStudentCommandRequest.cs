using Lms.Application.Features.Base;
using Lms.Application.Features.Commands.CreateProduct;
using Lms.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Student.Commands.CreateStudent
{
    public class CreateStudentCommandRequest : BaseRequest
    {
        public Guid UserId { get; set; }
        public string? School { get; set; }
        public string? Grade { get; set; }
    }
}
