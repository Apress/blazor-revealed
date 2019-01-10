using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace070.Client
{
  public static class DebuggingExtensions
  {
    public static string ToJson(this object obj)
    => Microsoft.JSInterop.Json.Serialize(obj);
  }

}
