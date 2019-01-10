using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPlace070.Shared
{
  public enum Spiciness
  {
    None,
    Spicy,
    Hot
  }

  public class Pizza
  {
    public Pizza() { }

    public Pizza(int id, string name, decimal price,
                 Spiciness spiciness)
    {
      this.Id = id;
      this.Name = name
        ?? throw new ArgumentNullException(nameof(name),
           "A pizza needs a name!");
      this.Price = price;
      this.Spiciness = spiciness;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Spiciness Spiciness { get; set; }
    public List<PizzaOrder> PizzaOrders { get; set; }
  }

}
