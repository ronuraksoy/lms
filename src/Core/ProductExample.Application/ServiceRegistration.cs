using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Lms.Application.Features.Commands.CreateProduct;
using Lms.Application.Features.Queries.GetAllProduct;
using Lms.Application.Features.Queries.GetByIdProduct;
using Lms.Application.Features.Queries.GetWhereProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Lms.Application
{
    static public class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
