using System;
using Aion.CustomerConfigService.Domain.Common;

namespace Aion.CustomerConfigService.Domain.Entities;

public class CustomerSegmentInstance : BaseEntity
{
    public CustomerSegmentInstance()
    {
    }

    public ICollection<CustomerSegmentInstanceEvent> CustomerSegmentInstanceEvents { get; }
}

