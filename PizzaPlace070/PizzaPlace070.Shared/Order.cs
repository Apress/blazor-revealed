using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPlace070.Shared
{
  public class Order
  {
    public int Id { get; set; }

    public Customer Customer { get; set; }

    public int CustomerId { get; set; }

    public List<PizzaOrder> PizzaOrders { get; set; }

    public decimal TotalPrice { get; set; }
  }

}
