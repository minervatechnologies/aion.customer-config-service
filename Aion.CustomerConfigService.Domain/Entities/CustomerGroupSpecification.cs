using System;
using Aion.CustomerConfigService.Domain.Common;

namespace Aion.CustomerConfigService.Domain.Entities;

public class CustomerGroupSpecification : BaseAuditableEntity
{
    public CustomerGroupSpecification(decimal yield, decimal roeRate, decimal externalRiskScore)
    {
        IsActive = false;
        IsEnabled = true;
        Yield = yield;
        RoeRate = roeRate;
        ExternalRiskScore = externalRiskScore;
    }

    public ICollection<CustomerGroupSpecificationEvent> CustomerSegmentInstanceEvents { get; }
    public decimal Yield { get; set; }
    public decimal RoeRate { get; set; }
    public decimal ExternalRiskScore { get;  }
    public bool IsActive { get; }
    public bool IsEnabled { get; }

    public Customer Customer { get; }
    public Guid CustomerId { get; }

    public CustomerGroupTemplate CustomerGroupTemplate { get; }
    public Guid CustomerGroupTemplateId { get; }
}