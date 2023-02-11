using System;
using Aion.CustomerConfigService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Aion.CustomerConfigService.Infrastructure.Persistence;

public class CustomerConfigDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public CustomerConfigDbContext(DbContextOptions<CustomerConfigDbContext> options, IConfiguration configuration)
        : base(options)
    {
        Configuration = configuration;
    }

    public DbSet<ContactPerson> ContactPeople { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerGroupSpecification> CustomerGroupSpecifications { get; set; }
    public DbSet<CustomerGroupSpecificationEvent> CustomerGroupSpecificationEvents { get; set; }
    public DbSet<CustomerGroupTemplate> CustomerGroupTemplates { get; set; }
    public DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(CustomerConfigDbContext).Assembly);

        // add seed data for customer group templates
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("ConfigDatabase"));
    }
}