using Meubelen.Domain.Entities;
using Meubelen.Domain.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meubelen.Domain.Services
{
    public interface IOrderServices
    {

        Order CreateOrder(Client client, Employee employee, Address address);
        Order CreateOrder(Client client, Employee employee, Address address, ICollection<Item> Items);


        PaginatedList<Order> GetClientOrders(int pageIndex, int pageSize, Guid CustomerKey);


        Order GetOrder(Guid Key);


        Order UpdateOrder(Order order, ICollection<Item> Items);

        Order UpdateOrder(Order order, ICollection<ItemToBeFactored> itemToBeFactored);



    }
}
