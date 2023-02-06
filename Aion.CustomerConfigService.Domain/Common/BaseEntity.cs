using System;
using System.Collections.Generic;

namespace Aion.CustomerConfigService.Domain.Common;

public abstract class BaseEntity
{
    public BaseEntity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; }
}