using Meubelen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meubelen.Domain.Services
{
    public interface IClient
    {
        Client CreateClient(User user);
        Client RemoveClient(Guid userKey);
      
    }
}
