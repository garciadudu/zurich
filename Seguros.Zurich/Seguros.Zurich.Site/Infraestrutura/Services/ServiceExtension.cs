using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RestSharp;
using Seguros.Zurich.Site.Infraestrutura.Clients.Configuration;
using Seguros.Zurich.Site.Infraestrutura.Services.Seguro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguros.Zurich.Site.Infraestrutura.Services
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ClientConfiguration>(configuration);

            services.AddScoped(serviceProvider =>
            {
                var config = serviceProvider.GetService<IOptionsSnapshot<ClientConfiguration>>();
                return new RestClient(config.Value.BaseUrl);
            });

            services.AddTransient<ISeguroService, SeguroService>();

            return services;
        }
    }
}
