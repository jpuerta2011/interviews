using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interviews.Data.Repositories.Base
{
    public interface IBaseRepository<in TIdType, T> : IRepository
    {
        Task<T> GetSingleByIdAsync(TIdType id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, List<string> includes = null);
        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> expression, List<string> includes = null);
        T Save(T entity);
        T Update(T entity);
        void Attach(T entity);
        void Remove(T entity);
        IQueryable<T> GetIQueryable(Expression<Func<T, bool>> expression, List<string> includes = null);
    }
}
