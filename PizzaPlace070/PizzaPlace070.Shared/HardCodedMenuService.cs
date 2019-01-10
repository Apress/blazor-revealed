using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace070.Shared
{
  public class HardCodedMenuService : IMenuService
  {
    public Task<Menu> GetMenu()
    {
      return Task.FromResult<Menu>(new Menu
      {
        Pizzas = new List<Pizza> {
          new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy ),
          new Pizza(2, "Margarita", 7.99M, Spiciness.None ),
          new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot )
        }
      });
    }
  }
}
