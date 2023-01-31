using System;
using Aion.CustomerConfigService.Domain.Common;

namespace Aion.CustomerConfigService.Domain.Entities;

public class CustomerGroupSpecification : BaseEntity
{
    public CustomerGroupSpecification()
    {
    }

    public ICollection<SegmentInstanceEvent> CustomerSegmentInstanceEvents { get; }
}

