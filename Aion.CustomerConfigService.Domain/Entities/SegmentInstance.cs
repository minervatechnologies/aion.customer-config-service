using System;
using Aion.CustomerConfigService.Domain.Common;

namespace Aion.CustomerConfigService.Domain.Entities;

public class SegmentInstance : BaseEntity
{
    public SegmentInstance()
    {
    }

    public ICollection<CustomerSegmentInstanceEvent> CustomerSegmentInstanceEvents { get; }
}

