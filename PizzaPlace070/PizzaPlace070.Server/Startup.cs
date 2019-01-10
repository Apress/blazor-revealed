using Microsoft.AspNetCore.Blazor.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net.Mime;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace PizzaPlace070.Server
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<PizzaPlaceDbContext>(options
   => options.UseSqlServer(
        Configuration.GetConnectionString("PizzaDb")));

      services.AddMvc();

      services.AddResponseCompression(options =>
      {
        options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
              {
                    MediaTypeNames.Application.Octet,
                    WasmMediaTypeNames.Application.Wasm,
          });
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      app.UseResponseCompression();

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseMvc(routes =>
      {
        routes.MapRoute(name: "default", template: "{controller}/{action}/{id?}");
      });

      app.UseBlazor<Client.Startup>();
    }
  }
}
