using Meubelen.Domain.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meubelen.Domain.Entities
{
    public class Journey : EntityBase
    {
        public DateTime Date { get; set; }
        public DateTime DepartAddress { get; set; }
        public DateTime ArrivalDate { get; set; }

    }
}
