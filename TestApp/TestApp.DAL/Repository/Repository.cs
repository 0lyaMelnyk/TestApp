using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.Abstract;

namespace TestApp.DAL.Repository
{
    public class Repository<T>: IRepository<T> where T:BaseEntity
    {
        private readonly TransactionContext context;
        public Repository(TransactionContext context)
        {
            this.context = context;
        }

        public async Task Create(T entity, string createBody = null)
        {
            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            T entity = await context.Set<T>().FindAsync(id);
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<T>> Get(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> list = context.Set<T>();
            if (filter != null)
                return await list?.Where(filter).ToListAsync();
            else return await list?.ToListAsync();
        }

        public async Task<T> Get(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity, string modifieBody = null)
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
