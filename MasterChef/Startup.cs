using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MasterChef.Models;

namespace MasterChef
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // add Mvc - Almir
            services.AddMvc();

            // Injeção de dependencia
            services.AddScoped<IReceitaServices, ReceitaServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // define default routers - Almir
            app.UseMvcWithDefaultRoute();
        }
    }
}
