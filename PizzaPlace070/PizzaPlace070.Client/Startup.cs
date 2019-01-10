using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using PizzaPlace070.Client.Services;
using PizzaPlace070.Shared;

namespace PizzaPlace070.Client
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      //services.AddTransient<IMenuService, HardCodedMenuService>();
      services.AddTransient<IMenuService, MenuService>();
      //services.AddTransient<IOrderService, ConsoleOrderService>();
      services.AddTransient<IOrderService, OrderService>();
      services.AddSingleton<State>();
    }

    public void Configure(IBlazorApplicationBuilder app)
    {
      app.AddComponent<App>("app");
    }
  }
}
