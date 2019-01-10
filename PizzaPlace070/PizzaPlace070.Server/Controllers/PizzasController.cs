using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPlace070.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace070.Server.Controllers
{
  //[Route("api/[controller]")]
  [ApiController]
  public class PizzasController : ControllerBase
  {
    private PizzaPlaceDbContext db;

    public PizzasController(PizzaPlaceDbContext db)
    {
      this.db = db;
    }

    //private static List<Pizza> pizzas = new List<Pizza>
    //{
    //  new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy ),
    //  new Pizza(2, "Margarita", 7.99M, Spiciness.None ),
    //  new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot )
    //};

    //[HttpGet("pizzas")]
    //public IQueryable<Pizza> GetPizzas() => pizzas.AsQueryable();

    [HttpGet("pizzas")]
    public IQueryable<Pizza> GetPizzas() => db.Pizzas;

    [HttpPost("pizzas")]
    public IActionResult InsertPizza([FromBody] Pizza pizza)
    {
      db.Pizzas.Add(pizza);
      db.SaveChanges();
      return Created($"pizzas/{pizza.Id}", pizza);
    }

  }
}