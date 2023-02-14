using Aion.CustomerConfigService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aion.CustomerConfigService.Infrastructure.Persistence.Configurations
{
    public class CustomerGroupTemplateConfiguration : IEntityTypeConfiguration<CustomerGroupTemplate>
    {
        public void Configure(EntityTypeBuilder<CustomerGroupTemplate> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Created);
            builder.Property(e => e.CreatedBy);
            builder.Property(e => e.LastModified);
            builder.Property(e => e.LastModifiedBy);
            builder.Property(e => e.Channel);
            builder.Property(e => e.Name);
            builder.Property(e => e.IsActive);
            builder.Property(e => e.LoanBrokerId);
        }
    }
}