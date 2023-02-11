using System;
using Aion.CustomerConfigService.Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Aion.CustomerConfigService.Infrastructure.Persistence
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly CustomerConfigDbContext dbContext;

        public BaseRepository(CustomerConfigDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<T> Add(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> GetById(Guid id) =>
            await dbContext.Set<T>().FindAsync(id);

        public async Task<IReadOnlyList<T>> ListAll() =>
            await dbContext.Set<T>().ToListAsync();

        public async Task Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}