using System;
namespace Aion.CustomerConfigService.Application.Queries;

public record GetGroupTemplateQuery(Guid segmentTemplateId) : IQuery;

