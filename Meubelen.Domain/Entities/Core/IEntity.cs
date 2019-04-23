using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meubelen.Domain.Entities.Core
{
    public interface IEntity
    {
        Guid Key { get; set; }
    }
}
