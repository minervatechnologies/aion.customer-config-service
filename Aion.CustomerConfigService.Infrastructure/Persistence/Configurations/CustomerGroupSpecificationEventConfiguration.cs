using Aion.CustomerConfigService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aion.CustomerConfigService.Infrastructure.Persistence.Configurations
{
    public class CustomerGroupSpecificationEventConfiguration : IEntityTypeConfiguration<CustomerGroupSpecificationEvent>
    {
        public void Configure(EntityTypeBuilder<CustomerGroupSpecificationEvent> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}