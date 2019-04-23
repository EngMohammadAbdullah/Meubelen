using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meubelen.Domain.Entities.Core
{
    public class EntityBase : IEntity
    {
        [Key]
        public Guid Key { get; set; }
    }
}
