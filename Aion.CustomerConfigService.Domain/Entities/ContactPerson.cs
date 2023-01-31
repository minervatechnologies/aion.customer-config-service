using System;
using Aion.CustomerConfigService.Domain.Common;

namespace Aion.CustomerConfigService.Domain.Entities;

public class ContactPerson : BaseAuditableEntity
{
    public ContactPerson()
    {
    }

    public string FirstName { get; }
    public string LastName { get; }

}

