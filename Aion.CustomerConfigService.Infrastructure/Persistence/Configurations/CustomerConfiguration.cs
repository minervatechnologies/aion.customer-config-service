using System;
using System.Diagnostics;
using System.Reflection.Emit;
using Aion.CustomerConfigService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aion.CustomerConfigService.Infrastructure.Persistence.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Created);
            builder.Property(e => e.CreatedBy);
            builder.Property(e => e.LastModified);
            builder.Property(e => e.LastModifiedBy);
            builder.Property(e => e.CompanyName);
            builder.Property(e => e.OrganisationalNumber);

            builder
                .HasMany(c => c.CustomerGroupSpecifications)
                .WithOne(co => co.Customer)
                .HasForeignKey(co => co.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(c => c.AccountGroups)
                .WithOne(co => co.Customer)
                .HasForeignKey(co => co.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(c => c.ContactPerson)
                .WithOne(contactPerson => contactPerson.Customer)
                .HasForeignKey<ContactPerson>(contactPerson => contactPerson.Id)
                .IsRequired(false);
        }
    }
}