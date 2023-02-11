using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Domain.Entities;

namespace Aion.CustomerConfigService.Application.Queries.Handlers;

public class GetSegmentTemplateQueryHandler : IQueryHandler<GetGroupTemplateQuery, CustomerGroupTemplate>
{
    private readonly ICustomerGroupTemplateRepository segmentTemplateRepository;

    public GetSegmentTemplateQueryHandler(ICustomerGroupTemplateRepository segmentTemplateRepository)
    {
        this.segmentTemplateRepository = segmentTemplateRepository;
    }

    public async Task<CustomerGroupTemplate> Execute(GetGroupTemplateQuery query)
    {
        if (query is null)
            throw new ArgumentNullException(nameof(query));

        await Task.FromResult(0);
        return null;
    }
}
