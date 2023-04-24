using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LenaSoftware.Business.Services.Abstract;
using LenaSoftware.Business.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;


namespace LenaSoftware.Business.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection BusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IFormService, FormManager>();
            return services;
        }
    }
}
