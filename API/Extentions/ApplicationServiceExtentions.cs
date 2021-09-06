using API.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using API.Services;
using API.Interfaces;

namespace API.Extentions
{
    public static class ApplicationServiceExtentions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options => {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}