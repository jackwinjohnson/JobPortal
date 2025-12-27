using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DataAccess.PortalRepository
{
    public interface IRepository<T>where T: class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>>filter=null);
        Task<T>GetByIdAsync(Guid id);
        Task<bool>AddAsync(T entity);
        Task<bool>UpdateAsync(T entity);
        Task<bool>DeleteAsync(Guid  Id);
        //Task<T>FirstOrDefaultAsync(Expression<Func<T,bool>>predicate);

    }
}
