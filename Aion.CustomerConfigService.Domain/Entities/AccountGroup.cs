using System;
using Aion.CustomerConfigService.Domain.Common;
using Aion.CustomerConfigService.Domain.Enums;

namespace Aion.CustomerConfigService.Domain.Entities
{
	public class AccountGroup : BaseAuditableEntity
    {
		public AccountGroup(AccountGroupType accountGroupType)
		{
            AccountGroupType = accountGroupType;
        }

		public AccountGroupType AccountGroupType { get; }
		public List<UserAccount> UserAccounts { get; }
        public Customer Customer { get; }
		public Guid CustomerId { get; }
	}
}