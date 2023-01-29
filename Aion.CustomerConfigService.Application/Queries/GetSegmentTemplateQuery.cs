using System;
namespace Aion.CustomerConfigService.Application.Queries;

public record GetSegmentTemplateQuery(Guid segmentTemplateId) : IQuery;

