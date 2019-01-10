using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPlace070.Shared;

namespace PizzaPlace070.Server.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
    private PizzaPlaceDbContext db;

    public OrdersController(PizzaPlaceDbContext db)
    {
      this.db = db;
    }

    [HttpPost("/orders")]
    public IActionResult CreateOrder([FromBody] Basket basket)
    {
      var customer = basket.Customer;
      var order = new Order()
      {
        PizzaOrders = new List<PizzaOrder>()
      };
      customer.Order = order;

      foreach (var pizzaId in basket.Orders)
      {
        var pizza = db.Pizzas.Single(p => p.Id == pizzaId);
        order.PizzaOrders.Add(new PizzaOrder
        {
          Pizza = pizza,
          Order = order
        });
      }

      order.TotalPrice =
        order.PizzaOrders.Sum(po => po.Pizza.Price);

      db.Customers.Add(customer);
      db.SaveChanges();

      return Ok();
    }
  }
}