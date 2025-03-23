using IceDream.Data.Context;
using IceDream.Data.Repositories.Interfaces;
using IceDream.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IceDream.Data.Repositories
{
    public abstract class BaseRepository<T>
        : IRepository<T> where T : AbstractEntity
    {
        protected readonly IceDreamContext Context;

        public BaseRepository(IceDreamContext context)
        {
            Context = context;
        }

        public virtual async Task AddAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public virtual void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }
    }
}
