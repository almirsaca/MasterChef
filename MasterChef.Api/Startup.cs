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
using MasterChef.Domain.Application;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using MasterChef.Repository.Repository;
using Newtonsoft.Json.Serialization;

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
            services.AddMvc()
            .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            services.Add(ServiceDescriptor.Scoped(typeof(DbContext), typeof(MasterChefContext)));
            services.Add(ServiceDescriptor.Scoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>)));
            services.Add(ServiceDescriptor.Scoped(typeof(IUnitOfWork), typeof(UnitOfWork)));
            services.Add(ServiceDescriptor.Scoped(typeof(IReceitaRepository), typeof(ReceitaRepository)));
            services.Add(ServiceDescriptor.Scoped(typeof(IUsuarioRepository), typeof(UsuarioRepository)));
            services.Add(ServiceDescriptor.Scoped(typeof(IReceitaService), typeof(ReceitaService)));
            services.Add(ServiceDescriptor.Scoped(typeof(IUsuarioService), typeof(UsuarioService)));
            services.Add(ServiceDescriptor.Scoped(typeof(ICategoriaService), typeof(ReceitaCategoriaService)));

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "Jwt";
                options.DefaultChallengeScheme = "Jwt";

            }).AddJwtBearer("Jwt", options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    //ValidAudience = "the audience you want to validate",
                    ValidateIssuer = false,
                    //ValidIssuer = "the isser you want to validate",
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("the secret that needs to be at least 16 characeters long for HmacSha256")),
                    ValidateLifetime = true, //validate the expiration and not before values in the token
                    ClockSkew = TimeSpan.FromMinutes(5) //5 minute tolerance for the expiration date
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod()
               .AllowCredentials());

            app.UseAuthentication();
            app.UseMvc();



        }
    }
}
