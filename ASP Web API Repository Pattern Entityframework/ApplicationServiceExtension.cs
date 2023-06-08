using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebApplication.DataAccess.Context;
using WebApplication.DataAccess.Interface;
using WebApplication.DataAccess.UnitOfWork;
using WebApplication.Services;
using WebApplication.Services.Interfaces;

namespace WebApplication
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddScoped<WebApplicationContext>(options => 
            {
                string connectionString = "Server=127.0.0.1;Port=5432;Database=postgres;User Id=postgres;Password=root;";
                return new WebApplicationContext(connectionString);
            });
            services.AddScoped<IEnumService,EnumService>();
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            
            return services;
        }
    }
}
