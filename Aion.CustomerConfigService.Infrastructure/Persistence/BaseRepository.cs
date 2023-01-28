using System;
using Aion.CustomerConfigService.Application.Repositories;

namespace Aion.CustomerConfigService.Infrastructure.Persistence
{
	public class BaseRepository<T> : IAsyncRepository<T> where T : class
	{
		public BaseRepository()
		{
		}

        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}