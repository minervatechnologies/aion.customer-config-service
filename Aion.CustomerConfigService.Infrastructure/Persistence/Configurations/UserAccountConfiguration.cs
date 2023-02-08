using Aion.CustomerConfigService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aion.CustomerConfigService.Infrastructure.Persistence.Configurations
{
    public class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Created);
            builder.Property(e => e.CreatedBy);
            builder.Property(e => e.LastModified);
            builder.Property(e => e.LastModifiedBy);
        }
    }
}