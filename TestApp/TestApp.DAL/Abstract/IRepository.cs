using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.DAL.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> Get(Expression<Func<T, bool>> filter = null);
        Task<T> Get(int id);
        Task Create(T entity, string createBody = null);
        Task Update(T entity, string modifieBody = null);
        Task Delete(int id);
    }
}
