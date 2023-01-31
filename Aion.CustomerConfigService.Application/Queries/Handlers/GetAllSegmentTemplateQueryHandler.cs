using System;
using System.Collections.Generic;
using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Domain.Entities;

namespace Aion.CustomerConfigService.Application.Queries.Handlers;

public class GetAllSegmentTemplateQueryHandler : IQueryHandler<GetAllSegmentTemplateQuery, IReadOnlyList<CustomerGroupTemplate>>
{
    private readonly ICustomerGroupTemplateRepository segmentTemplateRepository;

    public GetAllSegmentTemplateQueryHandler(ICustomerGroupTemplateRepository segmentTemplateRepository)
    {
        this.segmentTemplateRepository = segmentTemplateRepository;
    }

    public async Task<IReadOnlyList<CustomerGroupTemplate>> Execute(GetAllSegmentTemplateQuery query)
    {
        if (query is null)
            throw new ArgumentNullException(nameof(query));

        var templates = await segmentTemplateRepository.ListAll();

        if (templates is null)
            return new List<CustomerGroupTemplate>();

        return templates;
    }
}