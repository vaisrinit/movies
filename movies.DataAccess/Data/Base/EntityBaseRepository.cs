using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movies.Models;


namespace movies.DataAccess.Base;

public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
{
    private readonly AppDbContext _context;
    public EntityBaseRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task AddAsync(T entity)
    {
        await  _context.Set<T>().AddAsync(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        _context.SaveChanges();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        var result = await _context.Set<T>().ToListAsync();
        return result;
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var result = await _context.Set<T>().FirstOrDefaultAsync(n=>n.Id == id);
        return result;
    }

    public async Task<T> UpdateAsync(T entity)
    {
         _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}