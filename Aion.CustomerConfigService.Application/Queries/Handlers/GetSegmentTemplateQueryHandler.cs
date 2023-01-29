using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Domain.Entities;

namespace Aion.CustomerConfigService.Application.Queries.Handlers;

public class GetSegmentTemplateQueryHandler : IQueryHandler<GetSegmentTemplateQuery, SegmentTemplate>
{
    private readonly ISegmentTemplateRepository segmentTemplateRepository;

    public GetSegmentTemplateQueryHandler(ISegmentTemplateRepository segmentTemplateRepository)
    {
        this.segmentTemplateRepository = segmentTemplateRepository;
    }

    public async Task<SegmentTemplate> Execute(GetSegmentTemplateQuery query)
    {
        if (query is null)
            throw new ArgumentNullException(nameof(query));

        await Task.FromResult(0);
        return null;
    }
}