using System;
using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Domain.Entities;
using Aion.CustomerConfigService.Domain.Enums;
using Aion.CustomerConfigService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Aion.CustomerConfigService.Infrastructure.Persistence;

public class CustomerGroupSpecificationRepository : BaseRepository<CustomerGroupSpecification>, ICustomerGroupSpecificationRepository
{
    public CustomerGroupSpecificationRepository(CustomerConfigDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<CustomerGroupSpecification?> GetByIdAndLoanBroker(Guid customerId, LoanBrokeType loanBrokerType) =>
        await dbContext
         .CustomerGroupSpecifications
         .SingleOrDefaultAsync(
             s => s.CustomerId == customerId &&
             s.CustomerGroupTemplate.LoanBroker.Title == loanBrokerType);


}