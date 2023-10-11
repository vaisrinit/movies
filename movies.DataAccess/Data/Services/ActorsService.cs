using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movies.Models;

namespace movies.DataAccess.Services;

public class ActorsService : IActorsService
{
    private readonly AppDbContext _context;
    public ActorsService(AppDbContext context)
    {
        _context = context;
    }
    public async Task AddAsync(Actor actor)
    {
        await  _context.Actors.AddAsync(actor);
        _context.SaveChanges();

    }

    public void Delete(Actor actor)
    {
        _context.Remove(actor);
        _context.SaveChanges();
    }

    public async Task<IEnumerable<Actor>> GetAll()
    {
        var result = await _context.Actors.ToListAsync();
        return result;
    }

    public async Task<Actor> GetByIdAsync(int id)
    {
        var result = await _context.Actors.FirstOrDefaultAsync(n=>n.ActorId == id);
        return result;
    }

    public async Task <Actor> UpdateAsync(Actor newActor)
    {
        _context.Update(newActor);
        await _context.SaveChangesAsync();
        return newActor;
    }
}