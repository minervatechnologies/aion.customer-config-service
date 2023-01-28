using System;
namespace Aion.CustomerConfigService.Application.Queries.Handlers
{
	public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery
	{
		Task<TResult> Execute(TQuery query);
	}
}

