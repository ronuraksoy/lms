using Lms.Common.Domain.EntityExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Lms.Application
{
    static public class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            var serviceProvider = serviceCollection.BuildServiceProvider();

            serviceCollection.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());

            //DataResultExtensions.Configure(serviceProvider.GetService<IMapper>());
            EntityExtensions.Configure(serviceProvider.GetService<IHttpContextAccessor>());

            //serviceCollection.AddScoped<IAuditableService, AuditableService>();

            //ILoadUserValues loadValues = new LoadUserValues()
            //{
            //    SelectedChannelId = Guid.NewGuid(),
            //};
            //serviceCollection.Configure<ILoadUserValues>(options =>
            //{
            //    options = loadValues;
            //});
        }
    }
}
