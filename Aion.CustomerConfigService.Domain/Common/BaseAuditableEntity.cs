using System;
namespace Aion.CustomerConfigService.Domain.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    public BaseAuditableEntity()
    {
        Created = DateTime.Now;
    }

    public DateTime Created { get; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}