using Meubelen.Model.Dtos;
using Meubelen.Model.RequestCommands;
using Meubelen.Model.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using WebApiDoodle.Net.Http.Client;
using WebApiDoodle.Net.Http.Client.Model;

namespace Meubelen.Api.Client.Clients
{
    public class OrdersClient : HttpApiClient<OrderDto>,IOrderClient
    {
        private const string BaseUriTemplate = "api/Clients/{key}/Orders";
        private const string BaseUriTemplateForSingle = "api/affiliates/{key}/shipments/{shipmentKey}";
        private readonly string _clientKey;
        public OrdersClient(HttpClient httpClient, string clinetKey) : base(httpClient, MediaTypeFormatterCollection.Instance)
        {
            if (string.IsNullOrEmpty(clinetKey))
            {

                throw new ArgumentException("The argument 'clientKey' is null or empty.", "clientKey");
            }
            _clientKey = clinetKey;
        }
        public Task<OrderDto> AddOrderAsync(OrderBaseRequestModel OrderKey)
        {
            throw new NotImplementedException();
        }

        public  Task<OrderDto> GetOrderAsync(Guid OrderKey)
        {
            throw new NotImplementedException();
        }

        public async   Task<PaginatedDto<OrderDto>> GetOrdersAsync(PaginatedRequestCommand paginationCmd)
        {
            var parameters = new { key = _clientKey, page = paginationCmd.Page, take = paginationCmd.Take };
            var responseTask = base.GetAsync(BaseUriTemplate, parameters);

            var orders = await HandleResponseAsync(responseTask);
            return orders;
        }

        public Task<OrderDto> RemoveOrderAsync(Guid OrderKey)
        {
            throw new NotImplementedException();
        }


        // private helpers

        private async Task<TResult> HandleResponseAsync<TResult>(Task<HttpApiResponseMessage<TResult>> responseTask)
        {

            using (var apiResponse = await responseTask)
            {

                if (apiResponse.IsSuccess)
                {

                    return apiResponse.Model;
                }

                throw GetHttpApiRequestException(apiResponse);
            }
        }

        private async Task HandleResponseAsync(Task<HttpApiResponseMessage> responseTask)
        {

            using (var apiResponse = await responseTask)
            {

                if (!apiResponse.IsSuccess)
                {

                    throw GetHttpApiRequestException(apiResponse);
                }
            }
        }

        private HttpApiRequestException GetHttpApiRequestException(HttpApiResponseMessage apiResponse)
        {

            return new HttpApiRequestException(
                string.Format(ErrorMessages.HttpRequestErrorFormat, (int)apiResponse.Response.StatusCode, apiResponse.Response.ReasonPhrase),
                apiResponse.Response.StatusCode, apiResponse.HttpError);
        }

       
    }
}
