using System;
using Aion.CustomerConfigService.Domain.Common;
using Aion.CustomerConfigService.Domain.Enums;

namespace Aion.CustomerConfigService.Domain.Entities
{
	public class LoanBroker : BaseEntity
	{
		public LoanBroker()
		{
		}

		public LoanBrokerType Title { get;}
		public bool IsActive { get; set; }
	}
}