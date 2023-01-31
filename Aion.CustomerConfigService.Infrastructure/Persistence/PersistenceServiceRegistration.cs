using System;
using Aion.CustomerConfigService.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aion.CustomerConfigService.Infrastructure.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CustomerConfigDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CustomerConfigConnectionString")));


            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<I>


            return services;
        }
    }
}

