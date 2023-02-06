using System;
using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Domain.Entities;
using Aion.CustomerConfigService.Infrastructure.Persistence;

namespace Aion.CustomerConfigService.Infrastructure.Persistence;

public class CustomerGroupSpecificationRepository : BaseRepository<CustomerGroupSpecification>, ICustomerGroupSpecificationRepository
{
    public CustomerGroupSpecificationRepository(CustomerConfigDbContext dbContext) : base(dbContext)
    {

    }
}