using System;
using Aion.CustomerConfigService.Domain.Common;
using Aion.CustomerConfigService.Domain.Enums;

namespace Aion.CustomerConfigService.Domain.Entities;

public class CustomerGroupTemplate : BaseAuditableEntity
{
	public CustomerGroupTemplate(string channel)
	{
	}

    public string Channel { get; }
    public string Name { get;  }
    public bool IsActive { get; set; }
    public LoanBroker LoanBroker { get; }
	public Guid LoanBrokerId { get; }

    public ICollection<CustomerGroupSpecification> CustomerGroupSpecifications { get; }
}