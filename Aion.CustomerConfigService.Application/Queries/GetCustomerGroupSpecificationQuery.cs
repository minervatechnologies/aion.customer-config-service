using Aion.CustomerConfigService.Domain.Enums;

namespace Aion.CustomerConfigService.Application.Queries;

public record GetCustomerGroupSpecificationQuery(Guid CustomerId, LoanBrokeType LoanBrokerType) : IQuery;

