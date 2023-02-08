using System;
using Aion.CustomerConfigService.Domain.Common;

namespace Aion.CustomerConfigService.Domain.Entities;

public class CustomerGroupSpecification : BaseAuditableEntity
{
    public CustomerGroupSpecification(int yield, int roeRate, int externalRiskScore)
    {
        IsActive = false;
        IsEnabled = true;
        Yield = yield;
        RoeRate = roeRate;
        ExternalRiskScore = externalRiskScore;
    }

    public ICollection<CustomerGroupSpecificationEvent> CustomerSegmentInstanceEvents { get; }
    public int Yield { get; set; }
    public int RoeRate { get; set; }
    public int ExternalRiskScore { get; set; }
    public bool IsActive { get; set; }
    public bool IsEnabled { get; set; }

    public Customer Customer { get; }
    public Guid CustomerId { get; set; }

    public CustomerGroupTemplate CustomerGroupTemplate { get; }
    public Guid CustomerGroupTemplateId { get; }
}