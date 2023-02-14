using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Domain.Entities;
using Aion.CustomerConfigService.Domain.Enums;

public interface ICustomerGroupSpecificationRepository : IAsyncRepository<CustomerGroupSpecification>
{
    Task<CustomerGroupSpecification?> GetByIdAndLoanBroker(Guid customerId, LoanBrokeType loanBrokerType);
}


