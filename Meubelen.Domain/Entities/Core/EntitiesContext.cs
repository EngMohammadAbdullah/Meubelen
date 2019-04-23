using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meubelen.Domain.Entities.Core
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("MeubelenConnectionString")
        {
        }


    }
}
