using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meubelen.Domain.Entities;
using Meubelen.Domain.Entities.Core;

namespace Meubelen.Domain.Services
{
    public class OrderServices : IOrderServices
    {

        IEntityRepository<Order> _orderRepository;
        Client _client;
        Employee _employee;
        public OrderServices(
            IEntityRepository<Order> orderRepository,
            Client client, Employee employee
            )
        {
            _orderRepository = orderRepository;
            _client = client;
            _employee = employee;
        }


        public Order CreateOrder(Client client, Employee employee, Address address)
        {
            return CreateOrder(client, employee, address, null);
        }

        public Order CreateOrder(Client client, Employee employee, Address address, ICollection<Item> Items)
        {
            var order = new Order()
            {
                Client = client,
                Employee = employee,
                EmployeeKey = employee.Key,
                ClientKey = client.Key,
                Address = address,
                CreatedOn = DateTime.Now,
                DeliveryType = DeliveryType.ASAP

            };
            _orderRepository.Add(order);
            _orderRepository.Save();
            return order;
        }
        
        public Order GetOrder(Guid Key)
        {
            return _orderRepository.GetSingle(Key);
        }
               
        public PaginatedList<Order> GetClientOrders(int pageIndex, int pageSize, Guid CustomerKey)
        {
            var orders = _orderRepository.Paginate<Guid>(pageIndex, pageSize, x => x.ClientKey);
            return new PaginatedList<Order>(
                orders.PageIndex,
                orders.PageSize,
                orders.TotalCount,
                orders.Select(order => order).AsQueryable());
        }
               
        public Order UpdateOrder(Order order, ICollection<Item> Items)
        {
            order.Items = Items;
            _orderRepository.Edit(order);
            _orderRepository.Save();

            return order;
        }
               
        public Order UpdateOrder(Order order, ICollection<ItemToBeFactored> itemToBeFactored)
        {
            order.ItemToBeFactored = itemToBeFactored;
            _orderRepository.Edit(order);
            _orderRepository.Save();

            return order;
        }
    }
}
