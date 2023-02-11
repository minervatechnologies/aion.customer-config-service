using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Domain.Entities;

namespace Aion.CustomerConfigService.Application.Queries.Handlers;

public class GetCustomerGroupSpecificationQueryHandler : IQueryHandler<GetCustomerGroupSpecificationQuery, (decimal Yield, decimal Roe)>
{
    private readonly ICustomerGroupSpecificationRepository segmentTemplateRepository;

    public GetCustomerGroupSpecificationQueryHandler(ICustomerGroupSpecificationRepository segmentTemplateRepository)
    {
        this.segmentTemplateRepository = segmentTemplateRepository;
    }


    public async Task<(decimal Yield, decimal Roe)> Execute(GetCustomerGroupSpecificationQuery query)
    {
        var customerGroupSpecification = await segmentTemplateRepository.GetByIdAndLoanBroker(query.CustomerId, query.LoanBrokerType);
        if (customerGroupSpecification is null)
        {
            throw new ArgumentException(nameof(GetCustomerGroupSpecificationQuery));
        }

        return (Yield: customerGroupSpecification.Yield, Roe: customerGroupSpecification.RoeRate);
    }
}