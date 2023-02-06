using System;
using Aion.CustomerConfigService.Domain.Common;

namespace Aion.CustomerConfigService.Domain.Entities
{
    public class Customer : BaseAuditableEntity
    {
        public Customer(string organisationalNumber, string companyName)
        {
            OrganisationalNumber = organisationalNumber;
            CompanyName = companyName;
        }

        public string OrganisationalNumber { get; }
        public string CompanyName { get; }
        public bool IsActive { get; }

        public List<CustomerGroupSpecification> CustomerGroupSpecifications { get; set; }
    }
}

