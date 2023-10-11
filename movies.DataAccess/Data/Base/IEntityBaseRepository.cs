using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movies.Models;

namespace movies.DataAccess.Base;

public interface IEntityBaseRepository<T> where T:class,IEntityBase, new()
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T entity);
    Task <T> UpdateAsync(T entity);
    public void Delete(T entity);
    
}