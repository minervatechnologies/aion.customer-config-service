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
                options.UseNpgsql(configuration.GetConnectionString("CustomerConfigConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICustomerGroupTemplateRepository, CustomerGroupTemplateRepository>();
            services.AddScoped<ICustomerGroupSpecificationRepository, CustomerGroupSpecificationRepository>();

            // todo: register repositories

            return services;
        }
    }
}