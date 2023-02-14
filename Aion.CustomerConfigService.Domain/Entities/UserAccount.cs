using System;
using Aion.CustomerConfigService.Domain.Common;

namespace Aion.CustomerConfigService.Domain.Entities;

public class UserAccount : BaseAuditableEntity
{
    public UserAccount()
    {

    }

    public AccountGroup AccountGroup { get; }
    public Guid AccountGroupId { get; }
    public bool IsActive { get; set; }
}