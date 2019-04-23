using Meubelen.Domain.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meubelen.Domain.Entities
{
    public class Client : User
    {
        public Order Order { get; set; }
        public virtual ICollection<Order> Orders
        { get; set; }

        public Client()
        {
            Orders = new HashSet<Order>();
        }
    }
}
