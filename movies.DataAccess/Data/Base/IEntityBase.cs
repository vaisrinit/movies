using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movies.Models;

namespace movies.DataAccess.Base;

public interface IEntityBase
{
    int Id { get; set; }
    
}