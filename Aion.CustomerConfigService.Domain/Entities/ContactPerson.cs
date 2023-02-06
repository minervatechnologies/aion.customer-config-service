using System;
using Aion.CustomerConfigService.Domain.Common;

namespace Aion.CustomerConfigService.Domain.Entities;

public class ContactPerson : BaseAuditableEntity
{
    public ContactPerson(string firstName, string lastName, string emailAddress, string title, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        Title = title;
        PhoneNumber = phoneNumber;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string EmailAddress { get; }
    public string Title { get;}
    public string PhoneNumber { get; }
}

