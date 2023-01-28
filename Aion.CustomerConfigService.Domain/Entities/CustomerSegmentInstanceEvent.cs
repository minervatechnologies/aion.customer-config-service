using Aion.CustomerConfigService.Domain.Common;
using Aion.CustomerConfigService.Domain.Enums;

namespace Aion.CustomerConfigService.Domain.Entities;

public class CustomerSegmentInstanceEvent : BaseEntity
{
    public SegmentInstanceEvent SegmentInstanceEvent { get; } 
}

