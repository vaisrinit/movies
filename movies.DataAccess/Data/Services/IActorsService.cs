using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movies.Models;

namespace movies.DataAccess.Services;

public interface IActorsService
{
    Task<IEnumerable<Actor>> GetAll();
    Task<Actor> GetByIdAsync(int id);
    Task AddAsync(Actor actor);
    Task <Actor> UpdateAsync(Actor newActor);
    public void Delete(Actor actor);
}