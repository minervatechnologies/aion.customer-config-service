using Aion.CustomerConfigService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aion.CustomerConfigService.Infrastructure.Persistence.Configurations
{
    public class AccountGroupConfiguration : IEntityTypeConfiguration<AccountGroup>
    {
        public void Configure(EntityTypeBuilder<AccountGroup> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Created);
            builder.Property(e => e.CreatedBy);
            builder.Property(e => e.LastModified);
            builder.Property(e => e.LastModifiedBy);
            builder.Property(e => e.AccountGroupType);

            builder
                .HasMany(c => c.UserAccounts)
                .WithOne(co => co.AccountGroup)
                .HasForeignKey(co => co.AccountGroupId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}