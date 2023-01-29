using System;
using System.Collections.Generic;
using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Domain.Entities;

namespace Aion.CustomerConfigService.Application.Queries.Handlers;

public class GetAllSegmentTemplateQueryHandler : IQueryHandler<GetAllSegmentTemplateQuery, IReadOnlyList<SegmentTemplate>>
{
    private readonly ISegmentTemplateRepository segmentTemplateRepository;

    public GetAllSegmentTemplateQueryHandler(ISegmentTemplateRepository segmentTemplateRepository)
    {
        this.segmentTemplateRepository = segmentTemplateRepository;
    }

    public async Task<IReadOnlyList<SegmentTemplate>> Execute(GetAllSegmentTemplateQuery query)
    {
        if (query is null)
            throw new ArgumentNullException(nameof(query));

        var templates = await segmentTemplateRepository.ListAll();

        if (templates is null)
            return new List<SegmentTemplate>();

        return templates;
    }
}