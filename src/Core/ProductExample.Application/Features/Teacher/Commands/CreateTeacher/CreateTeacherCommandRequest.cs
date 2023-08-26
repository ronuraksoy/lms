﻿using Lms.Application.Features.Base;
using Lms.Application.Features.Commands.CreateProduct;
using Lms.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Features.Teacher.Commands.CreateTeacher
{
    public class CreateStudentCommandRequest : BaseRequest
    {
        public Guid UserId { get; set; }
        public string? Detail { get; set; }
        public string? Note { get; set; }
    }
}
