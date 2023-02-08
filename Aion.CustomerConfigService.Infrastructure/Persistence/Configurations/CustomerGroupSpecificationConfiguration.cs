using Aion.CustomerConfigService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aion.CustomerConfigService.Infrastructure.Persistence.Configurations
{
    public class CustomerGroupSpecificationConfiguration : IEntityTypeConfiguration<CustomerGroupSpecification>
    {
        public void Configure(EntityTypeBuilder<CustomerGroupSpecification> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Created);
            builder.Property(e => e.CreatedBy);
            builder.Property(e => e.LastModified);
            builder.Property(e => e.LastModifiedBy);

            builder.HasOne(c => c.CustomerGroupTemplate)
                .WithMany(e => e.CustomerGroupSpecifications)
                .HasForeignKey(c => c.CustomerGroupTemplateId);
        }
    }
}