using Aion.CustomerConfigService.Domain.Common;
using Aion.CustomerConfigService.Domain.Enums;

namespace Aion.CustomerConfigService.Domain.Entities;

public class CustomerGroupSpecificationEvent : BaseEntity
{
    public CustomerGroupSpecificationEventType SegmentInstanceEvent { get; } 
}

