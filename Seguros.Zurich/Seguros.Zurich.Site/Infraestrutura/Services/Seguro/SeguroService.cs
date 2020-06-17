using Microsoft.Extensions.Logging;
using RestSharp;
using Seguros.Zurich.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguros.Zurich.Site.Infraestrutura.Services.Seguro
{
    public class SeguroService : ServiceBase, ISeguroService
    {
        public SeguroService(RestClient client, ILogger<SeguroService> logger) : base(client, logger)
        {
            ResourceUri = "api/Seguro";
        }

        public Task<List<SeguroViewModel>> ListarAsync()
        {
            var request = CreateRequest(ResourceUri);
            return ExecuteAsync<List<SeguroViewModel>>(request);
        }

        public Task<SeguroViewModel> ObterAsync(int id)
        {
            var request = CreateRequest($"{ResourceUri}/{id}");
            return ExecuteAsync<SeguroViewModel>(request);
        }

        public Task CadastrarAsync(SeguroViewModel condominio)
        {
            var request = CreateRequest(ResourceUri, Method.POST);
            request.AddJsonBody(condominio);
            return ExecuteAsync(request);
        }

        public Task AtualizarAsync(SeguroViewModel condominio)
        {
            var request = CreateRequest($"{ResourceUri}/{condominio.Id}", Method.PUT);
            request.AddJsonBody(condominio);

            return ExecuteAsync(request);
        }

        public Task ExcluirAsync(int id)
        {
            var request = CreateRequest($"{ResourceUri}/{id}", Method.DELETE);
            return ExecuteAsync(request);
        }

        public Task<List<SeguroViewModel>> ListarMediaAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SeguroViewModel> ObterAsync(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
