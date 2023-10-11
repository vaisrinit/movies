using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movies.Models;

namespace movies.Data.Services;

public interface ICinemasService
{
    Task<IEnumerable<Actor>> GetAll();
    Actor GetById(int id);
    void Add(Actor actor);
    Actor Update(int id,Actor newActor);
    void Delete(int id);
}