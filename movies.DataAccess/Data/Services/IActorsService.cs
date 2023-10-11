using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movies.DataAccess.Base;
using movies.Models;

namespace movies.DataAccess.Services;

public interface IActorsService : IEntityBaseRepository<Actor>
{
    
}