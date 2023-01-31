using System;
namespace Aion.CustomerConfigService.Application.Repositories
{
	public interface IAsyncRepository<T> where T : class
	{
		Task<T> GetById(Guid id);
		Task<IReadOnlyList<T>> ListAll();
		Task<T> Add(T entity);
		Task Delete(T entity);
		Task Update(T entity);
    }
}

