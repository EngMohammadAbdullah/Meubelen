using Meubelen.Domain.Entities;
using Meubelen.Model.Dtos;
using Meubelen.Model.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDoodle.Net.Http.Client.Model;

namespace Meubelen.Api.Client.Clients
{
    public interface IOrderClient
    {
        Task<PaginatedDto<OrderDto>> GetOrdersAsync(
            OrderBaseRequestModel paginationCmd);

         Task<OrderDto> GetOrderAsync(Guid OrderKey);

         Task<OrderDto> AddOrderAsync(OrderBaseRequestModel OrderKey);

         Task<OrderDto> RemoveOrderAsync(Guid OrderKey);
    }
}
