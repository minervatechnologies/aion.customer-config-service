using System;
using Aion.CustomerConfigService.Domain.Entities;

namespace Aion.CustomerConfigService.Application.Queries.Handlers
{
    public class GetAllSegmentTemplateQueryHandler : IQueryHandler<GetAllSegmentTemplateQuery, SegmentTemplate>
    {
        public GetAllSegmentTemplateQueryHandler()
        {

        }

        public Task<SegmentTemplate> Execute(GetAllSegmentTemplateQuery query)
        {
            throw new NotImplementedException();
        }
    }
}

