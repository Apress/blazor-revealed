using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPlace070.Shared
{
  public class PizzaOrder
  {
    public int Id { get; set; }
    public Order Order { get; set; }
    public Pizza Pizza { get; set; }
  }

}
