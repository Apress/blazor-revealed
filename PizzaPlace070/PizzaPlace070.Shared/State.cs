using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaPlace070.Shared
{
  public class State
  {
    public Menu Menu { get; set; } = new Menu();

    public Basket Basket { get; set; } = new Basket();

    public UI UI { get; set; } = new UI();

    public decimal TotalPrice
      => Basket.Orders.Sum(id => Menu.GetPizza(id).Price);

    public Pizza CurrentPizza { get; set; }
  }

}
