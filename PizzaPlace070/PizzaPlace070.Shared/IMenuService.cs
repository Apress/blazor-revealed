using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace070.Shared
{
  public interface IMenuService
  {
    Task<Menu> GetMenu();
  }
}
