using LenaSoftware.DataAccess.Context;
using LenaSoftware.DataAccess.Repositories.Abstract;
using LenaSoftware.DataAccess.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LenaSoftware.DataAccess.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection DataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LenaSoftwareDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("LenaSoftware"));
            });
            services.AddScoped<IFormRepository, FormRepository>();
            return services;
        }
    }
}
