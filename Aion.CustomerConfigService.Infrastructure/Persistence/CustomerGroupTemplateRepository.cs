using System;
using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Domain.Entities;

namespace Aion.CustomerConfigService.Infrastructure.Persistence
{
	public class CustomerGroupTemplateRepository : BaseRepository<CustomerGroupTemplate>, ICustomerGroupTemplateRepository
    {
		public CustomerGroupTemplateRepository()
		{
		}
	}
}

