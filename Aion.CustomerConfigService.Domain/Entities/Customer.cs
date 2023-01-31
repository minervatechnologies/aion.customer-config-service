using System;
using Aion.CustomerConfigService.Domain.Common;

namespace Aion.CustomerConfigService.Domain.Entities
{
    public class Customer : BaseAuditableEntity
    {
        public Customer()
        {
        }

        public string OrganisationalNumber { get; set; }
        public string CompanyName { get; set; }

        public List<CustomerGroupSpecification> CustomerGroupSpecifications { get; set; }
    }
}

