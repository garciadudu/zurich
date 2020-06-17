using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Oracle.ManagedDataAccess.Client;
using Seguros.Zurich.Aplicacao.Interfaces;
using Seguros.Zurich.Aplicacao.Service;
using Seguros.Zurich.Domain.Core.Interface.Repository;
using Seguros.Zurich.Domain.Core.Service;
using Seguros.Zurich.Infraestrutura.Repository.Repositorio;
using Seguros.Zurich.Servicos.Service;

namespace Seguros.Zurich.Api
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
            services.AddControllers();

            OracleConfiguration.TraceFileLocation = @"C:\oraclexe\traces";
            OracleConfiguration.TraceLevel = 7;
            OracleConfiguration.TnsAdmin = @"C:\oraclexe\app\oracle\product\11.2.0\server\network\ADMIN";


            services.AddScoped<IApplicationServiceSeguro, ApplicationServiceSeguro>();

            services.AddScoped<IServiceSeguro, ServiceSeguro>();

            services.AddScoped<IRepositorySeguro, RepositorioSeguro>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
