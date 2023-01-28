using System;
using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Domain.Entities;

namespace Aion.CustomerConfigService.Infrastructure.Persistence
{
	public class SegmentTemplateRepository : BaseRepository<SegmentTemplate>, ISegmentTemplateRepository
    {
		public SegmentTemplateRepository()
		{
		}
	}
}

