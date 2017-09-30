using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MasterChef.Domain;
using MasterChef.Repository;
using MasterChef.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using MasterChef.Application;
using MasterChef.Application.Interfaces;

namespace MasterChef.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Add(ServiceDescriptor.Scoped(typeof(DbContext), typeof(MasterChefContext)));
            services.Add(ServiceDescriptor.Scoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>)));
            services.Add(ServiceDescriptor.Scoped(typeof(IUnitOfWork), typeof(UnitOfWork)));
            services.Add(ServiceDescriptor.Scoped(typeof(IReceitaRepository), typeof(ReceitaRepository)));
            services.Add(ServiceDescriptor.Scoped(typeof(IReceitaService), typeof(ReceitaService)));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
