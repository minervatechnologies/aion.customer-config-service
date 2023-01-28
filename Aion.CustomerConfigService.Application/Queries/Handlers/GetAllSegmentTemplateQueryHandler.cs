using System;
using Aion.CustomerConfigService.Domain.Entities;

namespace Aion.CustomerConfigService.Application.Queries.Handlers
{
    public class GetAllSegmentTemplateQueryHandler : IQueryHandler<GetAllTemplateQuery, SegmentTemplate>
    {
        public GetAllSegmentTemplateQueryHandler()
        {

        }

        public Task<SegmentTemplate> Execute(GetAllTemplateQuery query)
        {
            throw new NotImplementedException();
        }
    }
}

