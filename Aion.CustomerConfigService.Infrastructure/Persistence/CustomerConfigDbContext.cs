using System;
using Aion.CustomerConfigService.Domain.Entities;
using Aion.CustomerConfigService.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Aion.CustomerConfigService.Infrastructure.Persistence;

public class CustomerConfigDbContext : DbContext
{
    private const string ChannelLoanBroker = "Låneförmedlare";

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


        var lendoLoanBroker = new LoanBroker(LoanBrokeType.Lendo, true) { CreatedBy = "System" };
        var smartaLoanBroker = new LoanBroker(LoanBrokeType.Smarta, true) { CreatedBy = "System" };
        var ownChannel = new LoanBroker(LoanBrokeType.OwnChannel, true) { CreatedBy = "System" };
        var notLendoNotSmarta = new LoanBroker(LoanBrokeType.NotLendoNotSmarta, true) { CreatedBy = "System" };
        modelBuilder.Entity<LoanBroker>().HasData(lendoLoanBroker);
        modelBuilder.Entity<LoanBroker>().HasData(smartaLoanBroker);
        modelBuilder.Entity<LoanBroker>().HasData(ownChannel);
        modelBuilder.Entity<LoanBroker>().HasData(notLendoNotSmarta);

        var customerGroupTemplateOne = new CustomerGroupTemplate(ChannelLoanBroker, "Lendo Låg risk", true, lendoLoanBroker.Id);
        var customerGroupTemplateTwo = new CustomerGroupTemplate(ChannelLoanBroker, "Lendo Mellan risk", true, lendoLoanBroker.Id);
        var customerGroupTemplateThree = new CustomerGroupTemplate(ChannelLoanBroker, "Smarta", true, smartaLoanBroker.Id);
        var customerGroupTemplateFour = new CustomerGroupTemplate(ChannelLoanBroker, "Egen kanal", true, ownChannel.Id);
        var customerGroupTemplateFive = new CustomerGroupTemplate(ChannelLoanBroker, "Övriga förmedlare", true, notLendoNotSmarta.Id);
        modelBuilder.Entity<CustomerGroupTemplate>().HasData(customerGroupTemplateOne);
        modelBuilder.Entity<CustomerGroupTemplate>().HasData(customerGroupTemplateTwo);
        modelBuilder.Entity<CustomerGroupTemplate>().HasData(customerGroupTemplateThree);
        modelBuilder.Entity<CustomerGroupTemplate>().HasData(customerGroupTemplateFour);
        modelBuilder.Entity<CustomerGroupTemplate>().HasData(customerGroupTemplateFive);

        var contactPersonOne = new ContactPerson("Test Ett", "Testsson", "test@testsson.se", "Handläggare", "00000000");
        var contactPersonTwo = new ContactPerson("Test Två", "Testsson", "test@testsson.se", "Handläggare", "00000000");
        var contactPersonThree = new ContactPerson("Test Två", "Testsson", "test@testsson.se", "Handläggare", "00000000");

        var testCustomerOne = new Customer("112233", "Testbolag Ett");
        testCustomerOne.AddContactPerson(contactPersonOne);

        var testCustomerTwo = new Customer("113322", "Testbolag Två");
        testCustomerTwo.AddContactPerson(contactPersonTwo);

        var testCustomerThree = new Customer("223311", "Testbolag Tre");
        testCustomerThree.AddContactPerson(contactPersonThree);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("ConfigDatabase"));
    }
}