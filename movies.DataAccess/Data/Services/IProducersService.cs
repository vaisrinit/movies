using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movies.Models;

namespace movies.DataAccess.Services;

public interface IProducersService
{
    Task<IEnumerable<Producer>> GetAll();
    Producer GetById(int id);
    void Add(Producer producer);
    Actor Update(int id,Producer newProducer);
    void Delete(int id);
}