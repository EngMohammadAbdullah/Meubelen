using Meubelen.Domain.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meubelen.Domain.Entities
{
    public class Order : EntityBase
    {
        public Guid ClientKey { get; set; }
        public Guid EmployeeKey { get; set; }
        public DateTime CreatedOn { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public Address Address { get; set; }
        public Client Client { get; set; }
        public Employee  Employee { get; set; }
        public virtual ICollection<JourneyOrder> JourneyOrder { get; set; }
        public virtual ICollection<Item> Items
        { get; set; }
        public virtual ICollection<ItemToBeFactored> ItemToBeFactored

        { get; set; }
        public Order()
        {
            Items = new HashSet<Item>();
            ItemToBeFactored = new HashSet<ItemToBeFactored>();
            JourneyOrder = new HashSet<JourneyOrder>();
        }
    }
}
