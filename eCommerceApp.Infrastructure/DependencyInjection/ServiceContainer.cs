using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceApp.Domain.Entities;
using eCommerceApp.Domain.Interfaces;
using eCommerceApp.Infrastructure.Data;
using eCommerceApp.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace eCommerceApp.Infrastructure.DependencyInjection
{
  public static  class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services,IConfiguration config)
        {
            string connectionString = "default";

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString(connectionString), sqlOptions =>
            {
                sqlOptions.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
                sqlOptions.EnableRetryOnFailure();
            }), ServiceLifetime.Scoped);

            services.AddScoped<IGeneric<Product>, GenericRepo<Product>>();
            services.AddScoped<IGeneric<Category>, GenericRepo<Category>>();
            return services;

        }
    }
}
