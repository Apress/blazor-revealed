using Microsoft.AspNetCore.Blazor;
using PizzaPlace070.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PizzaPlace070.Client.Services
{
  public class OrderService : IOrderService
  {
    private HttpClient httpClient;

    public OrderService(HttpClient httpClient)
    {
      this.httpClient = httpClient;
    }

    public async Task PlaceOrder(Basket basket)
    {
      await httpClient.PostJsonAsync("/orders", basket);
    }
  }
}
