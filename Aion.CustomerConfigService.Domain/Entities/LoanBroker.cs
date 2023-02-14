using System;
using Aion.CustomerConfigService.Domain.Common;
using Aion.CustomerConfigService.Domain.Enums;

namespace Aion.CustomerConfigService.Domain.Entities
{
	public class LoanBroker : BaseAuditableEntity
	{
		public LoanBroker(LoanBrokeType title, bool isActive)
		{
            Title = title;
            IsActive = isActive;
        }

		public LoanBrokeType Title { get;}
        public bool IsActive { get; }
	}
}